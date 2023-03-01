namespace WSUniversalLib
{
    public class Calculation
    {
        int productType;
        int materialType;
        int count;
        float width;
        float length;
        public static int GetQuantityForProduct(int productType, int materialType, int count, float width, float lenght)
        {
            if (count <= 0) { return -1; }
            if (width <= 0) { return -1; }
            if (lenght <= 0) { return -1; }

            float S = width * lenght;
            float col = -1;
            switch(productType) 
            {
                case 1: col = S * (float)1.1; break;
                case 2: col = S * (float)2.5; break;
                case 3: col = S * (float)8.43; break;
            }
            if (col == -1) 
            {
                return -1;
            }
            else
            {
                col = col * count;
            }
            float brak = -1;
            switch(materialType) 
            {
                case 1: brak = col * (float)0.003; break;
                case 2: brak = col * (float)0.012; break;
            }
            if (brak == -1)
            {
                return -1;
            }
            col = brak + col;
            return Convert.ToInt32(col);
        }

    }
}