namespace WithTestProject
{
    public class BitsToString
    {
        public string ToString(bool bit3IsOn, bool bit2IsOn, bool bit1IsOn, bool bit0IsOn)
        {
            var number = 0;
            if (bit0IsOn) number += 1;
            if (bit1IsOn) number += 2;
            if (bit2IsOn) number += 4;
            if (bit3IsOn) number += 8;
            return $"{number:D2}";
        }
    }
}
