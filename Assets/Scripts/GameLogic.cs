using System;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    public float gameDuration = 100000000000f; // Spēles iespējamais ilgums
    public Text timerText; // Laika teksts
    public Objekti objektuSkripts;
    public Image[] starImages; // Zvaigžņu bildes masīvā
    public Image Menu; // Uz sākumu poga
    public Image Restart; // Sākt no sākuma poga

    private bool gameFinished = false; // Vai spēle ir beigusies?
    private float gameTimer = 0f; // Laika skaitītājs
    private int collectedStars = 0; // nopelnītās zvaigznes

    private void Start()
    {
        // Paslēpj uzvaras ekrānu
        foreach (Image starImage in starImages)
        {
            starImage.gameObject.SetActive(false);
            timerText.gameObject.SetActive(false);
            Menu.gameObject.SetActive(false);
            Restart.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (!gameFinished)
        {
            gameTimer += Time.deltaTime; // Atjaunina spēles laiku

            if (objektuSkripts.PlacedCarCount == 12)
            {
                GameFinished();
            }

            UpdateTimerText(); // Atjaunina laika tekstu
        }
    }

    private void GameFinished()
    {
        gameFinished = true;

        // Apreiķina zvaigžņu daudzumu atkarība no lietotāja ātruma
        collectedStars = CalculateStarCount();

        // Parāda vajadzīgo bildi salīdzinot ar nopelnītajām zvaigznēm
        ShowStarImages(collectedStars);
    }

    private int CalculateStarCount()
    {
        // Ja spēlētājs pabeidz spēli ātrāk par 70 sekundēm, tas saņem 3 zvaigznes
        if (gameTimer < 70f)
        {
            return 3;
        }
        // Ja spēlētājs pabeidz spēli ātrāk par 100 sekundēm, tas saņem 2 zvaigznes
        else if (gameTimer < 100f)
        {
            return 2;
        }
        // Ja spēlētājs pabeidz spēli vēlāk par 100 sekundēm, tas saņem 1 zvaigznes
        else
        {
            return 1;
        }
    }

    private void ShowStarImages(int starCount)
    {
        // Parāda spēles rezultātu spēlētājam, kad spēle ir pabeigta
        for (int i = 0; i < starCount; i++)
        {
            if (i < starImages.Length)
            {
                starImages[i].gameObject.SetActive(true);
                timerText.gameObject.SetActive(true);
                Menu.gameObject.SetActive(true);
                Restart.gameObject.SetActive(true);
            }
        }
    }

    private void UpdateTimerText()
    {
        //  Apreiķina laiku "hh:mm:ss" formātā
        TimeSpan timeSpan = TimeSpan.FromSeconds(gameTimer);
        string formattedTime = string.Format("{0:00}:{1:00}:{2:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);

        // Atjaunina laika tekstu
        timerText.text = "Jūsu laiks: " + formattedTime;
    }
}