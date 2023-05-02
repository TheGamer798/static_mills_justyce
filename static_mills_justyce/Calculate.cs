using System;
using System.Collections.Generic;
using System.Text;

namespace static_mills_justyce
{
    static class Calculate
    {

        public static float result = 0.0f;

        static Calculate()
        {
            result = 0.0f;
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            return x - y;
        }
        public static int Multi(int x, int y)
        {
            return x * y;
        }
        public static int Div(int x, int y)
        {
            return x / y;
        }

        public static float Add(float x, float y)
        {
            return x + y;
        }
        public static float Sub(float x, float y)
        {
            return x - y;
        }
        public static float Multi(float x, float y)
        {
            return x * y;
        }
        public static float Div(float x, float y)
        {
            return x / y;
        }
    }
}
