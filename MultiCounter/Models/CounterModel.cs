namespace MultiCounter.Models
{
    public class CounterModel
    {
        //==========define定義==========
        /// <summary>
        /// カウンタNo.定義
        /// </summary>
        public static readonly int DefCounter1 = 0;
        public static readonly int DefCounter2 = 1;
        public static readonly int DefCounter3 = 2;
        public static readonly int DefCounter4 = 3;
        public static readonly int DefCounter5 = 4;
        private static readonly int DefCounterMax = 5;

        //==========内部データ==========
        /// <summary>
        /// カウンタ
        /// </summary>
        private uint[] _counter = new uint[DefCounterMax];

        //==========コンストラクタ―==========
        /// <summary>
        /// コンストラクタ―
        /// </summary>
        public CounterModel()
        {
            ;
        }

        //==========メソッド==========
        /// <summary>
        /// カウンタインクリメント(カウンタNo.指定）
        /// </summary>
        /// <param name="selectedcounter">操作対象のカウンタNo.</param>
        /// <returns>カウンタインクリメント結果(文字列)</returns>
        public string IncrementSelectedCounter(int selectedcounter)
        {
            string countstring = "ERROR";

            if (selectedcounter < DefCounterMax)
            {
                if (_counter[selectedcounter] < uint.MaxValue)
                {
                    _counter[selectedcounter]++;
                }
                countstring = _counter[selectedcounter].ToString();
            }

            return countstring;
        }

        /// <summary>
        /// カウンタデクリメント(カウンタNo.指定）
        /// </summary>
        /// <param name="selectedcounter">操作対象のカウンタNo.</param>
        /// <returns>カウンタデクリメント結果(文字列)</returns>
        public string DecrementSelectedCounter(int selectedcounter)
        {
            string countstring = "ERROR";

            if (selectedcounter < DefCounterMax)
            {
                if (uint.MinValue < _counter[selectedcounter])
                {
                    _counter[selectedcounter]--;
                }
                countstring = _counter[selectedcounter].ToString();
            }

            return countstring;
        }

        /// <summary>
        /// カウンタクリア(カウンタNo.指定）
        /// </summary>
        /// <param name="selectedcounter">操作対象のカウンタNo.</param>
        /// <returns>カウンタクリア結果(文字列)</returns>
        public string ClearSelectedCounter(int selectedcounter)
        {
            string countstring = "ERROR";

            if (selectedcounter < DefCounterMax)
            {
                _counter[selectedcounter] = 0;
                countstring = _counter[selectedcounter].ToString();
            }

            return countstring;
        }
    }
}
