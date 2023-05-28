using System;
using UnityEngine;

namespace Glaas.Easings
{
    public static class Easings
    {
        public enum Curve
        {
            EaseInSine = 0,
            EaseOutSine = 1,
            EaseInOutSine = 2,

            EaseInQuad = 3,
            EaseOutQuad = 4,
            EaseInOutQuad = 5,

            EaseInCubic = 6,
            EaseOutCubic = 7,
            EaseInOutCubic = 8,

            EaseInQuart = 9,
            EaseOutQuart = 10,
            EaseInOutQuart = 11,

            EaseInQuint = 12,
            EaseOutQuint = 13,
            EaseInOutQuint = 14,

            EaseInExpo = 15,
            EaseOutExpo = 16,
            EaseInOutExpo = 17,

            EaseInCirc = 18,
            EaseOutCirc = 19,
            EaseInOutCirc = 20,

            EaseInBack = 21,
            EaseOutBack = 22,
            EaseInOutBack = 23,

            EaseInElastic = 24,
            EaseOutElastic = 25,
            EaseInOutElastic = 26,

            EaseInBounce = 27,
            EaseOutBounce = 28,
            EaseInOutBounce = 29,

            Linear = 30
        }

        public static string[] CurvesNames = new string[]
        {
            "EaseInSine",
            "EaseOutSine",
            "EaseInOutSine",

            "EaseInQuad",
            "EaseOutQuad",
            "EaseInOutQuad",

            "EaseInCubic",
            "EaseOutCubic",
            "EaseInOutCubic",

            "EaseInQuart",
            "EaseOutQuart",
            "EaseInOutQuart",

            "EaseInQuint",
            "EaseOutQuint",
            "EaseInOutQuint",

            "EaseInExpo",
            "EaseOutExpo",
            "EaseInOutExpo",

            "EaseInCirc",
            "EaseOutCirc",
            "EaseInOutCirc",

            "EaseInBack",
            "EaseOutBack",
            "EaseInOutBack",

            "EaseInElastic",
            "EaseOutElastic",
            "EaseInOutElastic",

            "EaseInBounce",
            "EaseOutBounce",
            "EaseInOutBounce",

            "Linear"
        };

        public static float EaseInSine(float x)
        {
            return 1 - Mathf.Cos((x * Mathf.PI) / 2);
        }

        public static float EaseOutSine(float x)
        {
            return Mathf.Sin((x * Mathf.PI) / 2);
        }

        public static float EaseInOutSine(float x)
        {
            return -(Mathf.Cos(Mathf.PI * x) - 1) / 2;
        }


        public static float EaseInQuad(float x)
        {
            return x * x;
        }

        public static float EaseOutQuad(float x)
        {
            return -(x * (x - 2));
        }

        public static float EaseInOutQuad(float x)
        {
            x *= 2;
            if (x < 1) return 0.5f * x * x;
            x--;
            return -0.5f * (x * (x - 2) - 1);
        }


        public static float EaseInCubic(float x)
        {
            return x * x * x;
        }

        public static float EaseOutCubic(float x)
        {
            x--;
            return (x * x * x + 1);
        }

        public static float EaseInOutCubic(float x)
        {
            x *= 2;
            if (x < 1) return 0.5f * x * x * x;
            x -= 2;
            return 0.5f * (x * x * x + 2);
        }


        public static float EaseInQuart(float x)
        {
            return x * x * x * x;
        }

        public static float EaseOutQuart(float x)
        {
            x--;
            return -(x * x * x * x - 1);
        }

        public static float EaseInOutQuart(float x)
        {
            x *= 2;
            if (x < 1) return 0.5f * x * x * x * x;
            x -= 2;
            return -0.5f * (x * x * x * x - 2);
        }


        public static float EaseInQuint(float x)
        {
            return x * x * x * x * x;
        }

        public static float EaseOutQuint(float x)
        {
            x--;
            return (x * x * x * x * x + 1);
        }

        public static float EaseInOutQuint(float x)
        {
            x *= 2;
            if (x < 1) return 0.5f * x * x * x * x * x;
            x -= 2;
            return 0.5f * (x * x * x * x * x + 2);
        }


        public static float EaseInExpo(float x)
        {
            return (x == 0) ? 0 : Mathf.Pow(2, 10 * (x - 1));
        }

        public static float EaseOutExpo(float x)
        {
            return (x == 1) ? 1 : (-Mathf.Pow(2, -10 * x) + 1);
        }

        public static float EaseInOutExpo(float x)
        {
            if (x == 0) return 0;
            if (x == 1) return 1;
            x *= 2;
            if (x < 1) return 0.5f * Mathf.Pow(2, 10 * (x - 1));
            x--;
            return 0.5f * (-Mathf.Pow(2, -10 * x) + 2);
        }


        public static float EaseInCirc(float x)
        {
            return -(Mathf.Sqrt(1 - (x * x)) - 1);
        }

        public static float EaseOutCirc(float x)
        {
            x--;
            return Mathf.Sqrt(1 - (x * x));
        }

        public static float EaseInOutCirc(float x)
        {
            x *= 2;
            if (x < 1) return -0.5f * (Mathf.Sqrt(1 - x * x) - 1);
            x -= 2;
            return 0.5f * (Mathf.Sqrt(1 - x * x) + 1);
        }


        public static float EaseInBack(float x)
        {
            float s = 1.70158f;
            return x * x * ((s + 1) * x - s);
        }

        public static float EaseOutBack(float x)
        {
            float s = 1.70158f;
            x--;
            return (x * x * ((s + 1) * x + s) + 1);
        }

        public static float EaseInOutBack(float x)
        {
            float s = 1.70158f;
            x *= 2;
            if (x < 1) return 0.5f * (x * x * ((s + 1) * x - s));
            x -= 2;
            return 0.5f * (x * x * ((s + 1) * x + s) + 2);
        }


        public static float EaseInElastic(float x)
        {
            if (x == 0) return 0;
            if (x == 1) return 1;
            float p = 0.3f;
            float s = p / 4;
            x -= 1;
            return -(Mathf.Pow(2, 10 * x) * Mathf.Sin((x - s) * (2 * Mathf.PI) / p));
        }

        public static float EaseOutElastic(float x)
        {
            if (x == 0) return 0;
            if (x == 1) return 1;
            float p = 0.3f;
            float s = p / 4;
            return Mathf.Pow(2, -10 * x) * Mathf.Sin((x - s) * (2 * Mathf.PI) / p) + 1;
        }

        public static float EaseInOutElastic(float x)
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


        public static float EaseInBounce(float x)
        {
            return 1 - EaseOutBounce(1 - x);
        }

        public static float EaseOutBounce(float x)
        {
            switch (x)
            {
                case < 1 / 2.75f:
                    return 7.5625f * x * x;
                case < 2 / 2.75f:
                    x -= (1.5f / 2.75f);
                    return 7.5625f * x * x + 0.75f;
                default:
                {
                    if (x < (2.5 / 2.75f))
                    {
                        x -= (2.25f / 2.75f);
                        return 7.5625f * x * x + 0.9375f;
                    }

                    x -= (2.625f / 2.75f);
                    return 7.5625f * x * x + 0.984375f;
                }
            }
        }

        public static float EaseInOutBounce(float x)
        {
            if (x < 0.5f) return EaseInBounce(x * 2) * 0.5f;
            return EaseOutBounce(x * 2 - 1) * 0.5f + 0.5f;
        }

        public static float Linear(float x)
        {
            return x;
        }

        public static Curve GetCurveByName(string name)
        {
            switch (name)
            {
                case "EaseInSine": return Curve.EaseInSine;
                case "EaseOutSine": return Curve.EaseOutSine;
                case "EaseInOutSine": return Curve.EaseInOutSine;
                case "EaseInQuad": return Curve.EaseInQuad;
                case "EaseOutQuad": return Curve.EaseOutQuad;
                case "EaseInOutQuad": return Curve.EaseInOutQuad;
                case "EaseInCubic": return Curve.EaseInCubic;
                case "EaseOutCubic": return Curve.EaseOutCubic;
                case "EaseInOutCubic": return Curve.EaseInOutCubic;
                case "EaseInQuart": return Curve.EaseInQuart;
                case "EaseOutQuart": return Curve.EaseOutQuart;
                case "EaseInOutQuart": return Curve.EaseInOutQuart;
                case "EaseInQuint": return Curve.EaseInQuint;
                case "EaseOutQuint": return Curve.EaseOutQuint;
                case "EaseInOutQuint": return Curve.EaseInOutQuint;
                case "EaseInExpo": return Curve.EaseInExpo;
                case "EaseOutExpo": return Curve.EaseOutExpo;
                case "EaseInOutExpo": return Curve.EaseInOutExpo;
                case "EaseInCirc": return Curve.EaseInCirc;
                case "EaseOutCirc": return Curve.EaseOutCirc;
                case "EaseInOutCirc": return Curve.EaseInOutCirc;
                case "EaseInBack": return Curve.EaseInBack;
                case "EaseOutBack": return Curve.EaseOutBack;
                case "EaseInOutBack": return Curve.EaseInOutBack;
                case "EaseInElastic": return Curve.EaseInElastic;
                case "EaseOutElastic": return Curve.EaseOutElastic;
                case "EaseInOutElastic": return Curve.EaseInOutElastic;
                case "EaseInBounce": return Curve.EaseInBounce;
                case "EaseOutBounce": return Curve.EaseOutBounce;
                case "EaseInOutBounce": return Curve.EaseInOutBounce;
                case "Linear": return Curve.Linear;
                default: throw new System.Exception("Curve not found: " + name);
            }
        }

        public static float Evaluate(float x, Curve curve)
        {
            switch (curve)
            {
                case Curve.EaseInSine:
                    return EaseInSine(x);
                case Curve.EaseOutSine:
                    return EaseOutSine(x);
                case Curve.EaseInOutSine:
                    return EaseInOutSine(x);
                case Curve.EaseInQuad:
                    return EaseInQuad(x);
                case Curve.EaseOutQuad:
                    return EaseOutQuad(x);
                case Curve.EaseInOutQuad:
                    return EaseInOutQuad(x);
                case Curve.EaseInCubic:
                    return EaseInCubic(x);
                case Curve.EaseOutCubic:
                    return EaseOutCubic(x);
                case Curve.EaseInOutCubic:
                    return EaseInOutCubic(x);
                case Curve.EaseInQuart:
                    return EaseInQuart(x);
                case Curve.EaseOutQuart:
                    return EaseOutQuart(x);
                case Curve.EaseInOutQuart:
                    return EaseInOutQuart(x);
                case Curve.EaseInQuint:
                    return EaseInQuint(x);
                case Curve.EaseOutQuint:
                    return EaseOutQuint(x);
                case Curve.EaseInOutQuint:
                    return EaseInOutQuint(x);
                case Curve.EaseInExpo:
                    return EaseInExpo(x);
                case Curve.EaseOutExpo:
                    return EaseOutExpo(x);
                case Curve.EaseInOutExpo:
                    return EaseInOutExpo(x);
                case Curve.EaseInCirc:
                    return EaseInCirc(x);
                case Curve.EaseOutCirc:
                    return EaseOutCirc(x);
                case Curve.EaseInOutCirc:
                    return EaseInOutCirc(x);
                case Curve.EaseInBack:
                    return EaseInBack(x);
                case Curve.EaseOutBack:
                    return EaseOutBack(x);
                case Curve.EaseInOutBack:
                    return EaseInOutBack(x);
                case Curve.EaseInElastic:
                    return EaseInElastic(x);
                case Curve.EaseOutElastic:
                    return EaseOutElastic(x);
                case Curve.EaseInOutElastic:
                    return EaseInOutElastic(x);
                case Curve.EaseInBounce:
                    return EaseInBounce(x);
                case Curve.EaseOutBounce:
                    return EaseOutBounce(x);
                case Curve.EaseInOutBounce:
                    return EaseInOutBounce(x);
                case Curve.Linear:
                    return Linear(x);
                default:
                    throw new ArgumentOutOfRangeException(nameof(curve), curve, null);
            }
        }
    }
}