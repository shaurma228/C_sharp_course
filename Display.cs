using System;

class Display : Screen
{
    string type; //display type (OLED, IPS etc.)
    int refR; //refresh rate

    public Display(int resH, int resV, int size, string type, int refR) : base(resH, resV, size)
    {
        this.type = type;
        this.refR = refR;
    }

    public string Type
    {
        get { return type; }
    }

    public int RefreshRate
    {
        get { return refR; }
    }

    public string Ratio()
    {
        int a = resV, b = resH;
        int temp;
        while (b != 0)
        {
            temp = b;
            b = a % b;
            a = temp;
        }
        return $"{resH / a}:{resV / a}";
    }

    public double PPI()
    {
        return Math.Round(Math.Sqrt(resV * resV + resH * resH) / size, 1);
    }

    public override string ToString()
    {
        return base.ToString() + $", Type: {type}, Refresh rate: {refR}HZ";
    }
}