for (int huehner = 1; huehner <= 50; huehner++)
{
    int gaense = huehner * 2;

    for (int schafe = 1; schafe <= 50; schafe++)
    {
        int kaninchen = schafe * 3;

        int beine =
            huehner * 2 +
            gaense * 2 +
            schafe * 4 +
            kaninchen * 4;

        if (beine == 90)
        {
            txtOutput.Text =
                "Hühner: " + huehner + "\n" +
                "Gänse: " + gaense + "\n" +
                "Schafe: " + schafe + "\n" +
                "Kaninchen: " + kaninchen;
        }
    }
}

