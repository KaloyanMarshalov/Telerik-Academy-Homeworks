namespace _05.Vars_Data_Expr_Cons
{
    using System;
    class PrintStatistics
    {
        public void PrintStatistics(double[] statisticsArray, int numberOfStatistics)
        {
            double maxStatistic = this.GetMaxStatistic(statisticsArray, numberOfStatistics);
            this.Print(maxStatistic);

            double minStatistic = this.GetMinStatistic(statisticsArray, numberOfStatistics);
            this.Print(minStatistic);

            var sumOfStatistics = GetSumOfStatistics(statisticsArray, numberOfStatistics);
            var averageStatistics = sumOfStatistics / numberOfStatistics;
            this.Print(averageStatistics);
        }

        private void Print(double input)
        {
            Console.WriteLine(input);
        }

        private double GetMaxStatistic(double[] statisticsArray, int numberOfStatistics)
        {
            double maxStatistic = 0;

            for (int i = 0; i < numberOfStatistics; i++)
            {
                if (statisticsArray[i] > maxStatistic)
                {
                    maxStatistic = statisticsArray[i];
                }
            }

            return maxStatistic;
        }

        private double GetMinStatistic(double[] statisticsArray, int numberOfStatistics)
        {
            double minStatistic = 0;

            for (int i = 0; i < numberOfStatistics; i++)
            {
                if (statisticsArray[i] < minStatistic)
                {
                    minStatistic = statisticsArray[i];
                }
            }

            return minStatistic;
        }

		private double GetSumOfStatistics(double[] statisticsArray, int numberOfStatistics)
        {
            double sumOfStatistcs = 0;

            for (int i = 0; i < numberOfStatistics; i++)
            {
                sumOfStatistcs += statisticsArray[i];
            }

            return sumOfStatistcs;
        }
    }
}
