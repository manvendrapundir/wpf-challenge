public class Stock
    {
        private string symbol;

        public string Symbol
        {
            get { return symbol; }
            set
            {
                symbol = value;
            }
        }

        private string valueDateTime;

        public string ValueDateTime
        {
            get { return valueDateTime; }
            set
            {
                valueDateTime = value;
            }
        }

        private int openPrice;

        public int OpenPrice
        {
            get { return openPrice; }
            set
            {
                openPrice = value;
            }
        }

        private int currentPrice;

        public int CurrentPrice
        {
            get { return currentPrice; }
            set
            {
                currentPrice = value;
            }
        }

        private decimal percentChangeDecimal;

        public decimal PercentChangeDecimal
        {
            get { return percentChangeDecimal; }
            set
            {
                percentChangeDecimal = value;
            }
        }

        private void CalculatePercentChange(int oldPrice, int newPrice)
        {
            if (oldPrice != 0)
            {
                percentChangeDecimal = ((decimal)(newPrice - oldPrice) / oldPrice) * 100;
                percentChangeDecimal = Math.Round(percentChangeDecimal, 2);
            }
        }
    }
