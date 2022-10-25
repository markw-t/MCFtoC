namespace Refactorings
{
    public static class TemperatureConversions
    {
        public static double FtoC(double temperatureInF, bool toggle)
        {
            //T(°C) = (T(°F) - 32) × 5 / 9
            if(toggle)
            {
                double temperatureInC = (temperatureInF - 32) * (5.0 / 9.0);
                return temperatureInC;
            }
            else
            {
                return 0;
            }
        }

        public static double CtoF(double temperatureInC, bool toggle)
        {
            //T(°F) = (T(°C) × 9 / 5) + 32
            if(toggle)
            {
                double temperatureInF = (temperatureInC * (9.0 / 5.0)) + 32;
                return temperatureInF;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Converts temperatures from one unit of measure to another
        /// </summary>
        /// <param name="Conversion">the input and output units desired</param>
        /// <param name="temperature">temperature to be converted</param>
        /// <returns>temperature in the specified output unit</returns>
        public static double Convert(Conversion conversion, double temperature)
        {
            double outTemperature = temperature;

            if (conversion == Conversion.FtoC)
            {
                //F to C: T(°C) = (T(°F) - 32) × 5 / 9
                outTemperature = (temperature - 32) * (5.0 / 9.0);
            }

            if (conversion == Conversion.CtoF)
            {
                //C to F: T(°F) = (T(°C) × 9 / 5) + 32
                outTemperature = (temperature * (9.0 / 5.0)) + 32;

            }

            return outTemperature;
        }
        /// <summary>
        /// Temperature units for conversion
        /// </summary>
        public enum Conversion { FtoC, CtoF }

    }
}
