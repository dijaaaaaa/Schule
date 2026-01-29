string text = "";

for (char buchstabe = 'A'; buchstabe <= 'H'; buchstabe++)
{
    for (int zahl = 1; zahl <= 8; zahl++)
    {
        text += buchstabe + zahl + " ";
    }
    text += "\n";
}

txtOutput.Text = text;

