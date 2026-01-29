double summe = 0;
int anzahl = 0;
double zahl;

do
{
    zahl = double.Parse(txtInput.Text);

    if (zahl != 0)
    {
        summe += zahl;
        anzahl++;
    }
}
while (zahl != 0);

double mittelwert = summe / anzahl;
txtOutput.Text = "Mittelwert: " + mittelwert;

