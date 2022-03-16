using UnityEngine;
namespace Glaas.EasingsCurves
{
    public static class Easings
    {
        public enum curveType
        {
            easeInSine = 0,
            easeOutSine = 1,
            easeInOutSine = 2,


            easeInQuad = 3,
            easeOutQuad = 4,
            easeInOutQuad = 5,


            easeInCubic = 6,
            easeOutCubic = 7,
            easeInOutCubic = 8,


            easeInQuart = 9,
            easeOutQuart = 10,
            easeInOutQuart = 11,


            easeInQuint = 12,
            easeOutQuint = 13,
            easeInOutQuint = 14,

            easeInExpo = 15,
            easeOutExpo = 16,
            easeInOutExpo = 17,


            easeInCirc = 18,
            easeOutCirc = 19,
            easeInOutCirc = 20,


            easeInBack = 21,
            easeOutBack = 22,
            easeInOutBack = 23,


            easeInElastic = 24,
            easeOutElastic = 25,
            easeInOutElastic = 26,


            easeInBounce = 27,
            easeOutBounce = 28,
            easeInOutBounce = 29
        }
        public static string[] curves = new string[] {
            "easeInSine",
            "easeOutSine",
            "easeInOutSine",

            "easeInQuad",
            "easeOutQuad",
            "easeInOutQuad",

            "easeInCubic",
            "easeOutCubic",
            "easeInOutCubic",

            "easeInQuart",
            "easeOutQuart",
            "easeInOutQuart",

            "easeInQuint",
            "easeOutQuint",
            "easeInOutQuint",

            "easeInExpo",
            "easeOutExpo",
            "easeInOutExpo",

            "easeInCirc",
            "easeOutCirc",
            "easeInOutCirc",

            "easeInBack",
            "easeOutBack",
            "easeInOutBack",

            "easeInElastic",
            "easeOutElastic",
            "easeInOutElastic",

            "easeInBounce",
            "easeOutBounce",
            "easeInOutBounce"
        };

        public static float easeInSine(float x) { return 1 - Mathf.Cos((x * Mathf.PI) / 2); }
        public static float easeOutSine(float x) { return Mathf.Sin((x * Mathf.PI) / 2); }
        public static float easeInOutSine(float x) { return -(float)(Mathf.Cos(Mathf.PI * x) - 1) / 2; }


        public static float easeInQuad(float x) { return x * x; }
        public static float easeOutQuad(float x) { return -(x * (x - 2)); }
        public static float easeInOutQuad(float x)
        {
            x *= 2;
            if (x < 1) return 0.5f * x * x;
            x--;
            return -0.5f * (x * (x - 2) - 1);
        }


        public static float easeInCubic(float x) { return x * x * x; }
        public static float easeOutCubic(float x)
        {
            x--;
            return (x * x * x + 1);
        }
        public static float easeInOutCubic(float x)
        {
            x *= 2;
            if (x < 1) return 0.5f * x * x * x;
            x -= 2;
            return 0.5f * (x * x * x + 2);
        }


        public static float easeInQuart(float x) { return x * x * x * x; }
        public static float easeOutQuart(float x)
        {
            x--;
            return -(x * x * x * x - 1);
        }
        public static float easeInOutQuart(float x)
        {
            x *= 2;
            if (x < 1) return 0.5f * x * x * x * x;
            x -= 2;
            return -0.5f * (x * x * x * x - 2);
        }


        public static float easeInQuint(float x) { return x * x * x * x * x; }
        public static float easeOutQuint(float x)
        {
            x--;
            return (x * x * x * x * x + 1);
        }
        public static float easeInOutQuint(float x)
        {
            x *= 2;
            if (x < 1) return 0.5f * x * x * x * x * x;
            x -= 2;
            return 0.5f * (x * x * x * x * x + 2);
        }


        public static float easeInExpo(float x) { return (x == 0) ? 0 : Mathf.Pow(2, 10 * (x - 1)); }
        public static float easeOutExpo(float x) { return (x == 1) ? 1 : (-Mathf.Pow(2, -10 * x) + 1); }
        public static float easeInOutExpo(float x)
        {
            if (x == 0) return 0;
            if (x == 1) return 1;
            x *= 2;
            if (x < 1) return 0.5f * Mathf.Pow(2, 10 * (x - 1));
            x--;
            return 0.5f * (-Mathf.Pow(2, -10 * x) + 2);
        }


        public static float easeInCirc(float x) { return -(Mathf.Sqrt(1 - (x * x)) - 1); }
        public static float easeOutCirc(float x)
        {
            x--;
            return Mathf.Sqrt(1 - (x * x));
        }
        public static float easeInOutCirc(float x)
        {
            x *= 2;
            if (x < 1) return -0.5f * (Mathf.Sqrt(1 - x * x) - 1);
            x -= 2;
            return 0.5f * (Mathf.Sqrt(1 - x * x) + 1);
        }


        public static float easeInBack(float x)
        {
            float s = 1.70158f;
            return x * x * ((s + 1) * x - s);
        }
        public static float easeOutBack(float x)
        {
            float s = 1.70158f;
            x--;
            return (x * x * ((s + 1) * x + s) + 1);
        }
        public static float easeInOutBack(float x)
        {
            float s = 1.70158f;
            x *= 2;
            if (x < 1) return 0.5f * (x * x * ((s + 1) * x - s));
            x -= 2;
            return 0.5f * (x * x * ((s + 1) * x + s) + 2);
        }


        public static float easeInElastic(float x)
        {
            if (x == 0) return 0;
            if (x == 1) return 1;
            float p = 0.3f;
            float s = p / 4;
            x -= 1;
            return -(Mathf.Pow(2, 10 * x) * Mathf.Sin((x - s) * (2 * Mathf.PI) / p));
        }
        public static float easeOutElastic(float x)
        {
            if (x == 0) return 0;
            if (x == 1) return 1;
            float p = 0.3f;
            float s = p / 4;
            return Mathf.Pow(2, -10 * x) * Mathf.Sin((x - s) * (2 * Mathf.PI) / p) + 1;
        }
        public static float easeInOutElastic(float x)
        {
            if (x == 0) return 0;
            if (x == 1) return 1;
            float p = 0.45f;
            float s = p / 4;
            x *= 2;
            if (x < 1) return -0.5f * (Mathf.Pow(2, 10 * (x - 1)) * Mathf.Sin((x - s) * (2 * Mathf.PI) / p));
            x -= 1;
            return Mathf.Pow(2, -10 * x) * Mathf.Sin((x - s) * (2 * Mathf.PI) / p) * 0.5f + 1;
        }


        public static float easeInBounce(float x) { return 1 - easeOutBounce(1 - x); }
        public static float easeOutBounce(float x)
        {
            if (x < (1 / 2.75f))
            {
                return 7.5625f * x * x;
            }
            else if (x < (2 / 2.75f))
            {
                x -= (1.5f / 2.75f);
                return 7.5625f * x * x + 0.75f;
            }
            else if (x < (2.5 / 2.75f))
            {
                x -= (2.25f / 2.75f);
                return 7.5625f * x * x + 0.9375f;
            }
            else
            {
                x -= (2.625f / 2.75f);
                return 7.5625f * x * x + 0.984375f;
            }
        }
        public static float easeInOutBounce(float x)
        {
            if (x < 0.5f) return easeInBounce(x * 2) * 0.5f;
            return easeOutBounce(x * 2 - 1) * 0.5f + 0.5f;
        }
    }
}

