using UnityEngine;
using UnityEngine.UI;

namespace WithoutTestProject
{
    /// <summary>
    /// トグルのon/offに合わせた数値を十進数で表示する
    /// </summary>
    public class SampleScene : MonoBehaviour
    {
        [SerializeField] Text text;
        [SerializeField] Button[] buttons;

        int[] _bits = new int[4];

        public void OnClickButton0()
        {
            _bits[0] = _bits[0] == 0 ? 1 : 0;
            buttons[0].image.color = _bits[0] == 1 ? Color.red : Color.white;
            UpdateText();
        }

        public void OnClickButton1()
        {
            _bits[1] = _bits[1] == 0 ? 1 : 0;
            buttons[1].image.color = _bits[1] == 1 ? Color.red : Color.white;
            UpdateText();
        }

        public void OnClickButton2()
        {
            _bits[2] = _bits[2] == 0 ? 1 : 0;
            buttons[2].image.color = _bits[2] == 1 ? Color.red : Color.white;
            UpdateText();
        }

        public void OnClickButton3()
        {
            _bits[3] = _bits[3] == 0 ? 1 : 0;
            buttons[3].image.color = _bits[3] == 1 ? Color.red : Color.white;
            UpdateText();
        }

        void UpdateText()
        {
            var number = 0;
            for (var i = 0; i < _bits.Length; i++)
            {
                number += (_bits[i] << i);
            }
            text.text = number.ToString("D2");
        }
    }
}
