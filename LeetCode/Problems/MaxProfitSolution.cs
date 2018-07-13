﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class MaxProfitSolution
    {
        public MaxProfitSolution()
        {
            //MaxProfit(new int[] { 4680, 4209, 710, 364, 1213, 4092, 931, 436, 4408, 3929, 978, 2355, 3867, 1060, 109, 904, 1675, 1762, 1331, 3883, 2179, 3326, 1083, 4292, 295, 905, 806, 25, 3060, 3701, 2282, 1849, 4671, 3260, 1461, 3755, 1382, 696, 326, 21, 2355, 3412, 860, 451, 4317, 3351, 231, 3458, 603, 2390, 167, 405, 4152, 1640, 2974, 41, 2305, 1682, 1090, 2158, 4583, 318, 1583, 918, 3346, 4420, 1334, 1966, 4727, 4783, 1694, 3746, 804, 3230, 1831, 2261, 2436, 1436, 3216, 2112, 1170, 3671, 179, 823, 2221, 1622, 4976, 2343, 4098, 1418, 4220, 4135, 2799, 4064, 4064, 2325, 384, 1306, 4305, 4977, 4461, 962, 3075, 4277, 3295, 440, 4645, 1573, 377, 2430, 3095, 2688, 1933, 2948, 989, 3453, 1751, 4132, 4256, 3326, 3952, 4163, 4947, 852, 4415, 4147, 24, 4337, 2973, 2802, 4255, 3095, 1066, 2080, 4948, 1866, 2268, 2680, 4876, 4937, 627, 561, 4412, 869, 1070, 349, 1458, 4511, 1727, 453, 3319, 1566, 98, 2731, 263, 4999, 677, 571, 1698, 3027, 2811, 3364, 2899, 1265, 2070, 2281, 589, 3245, 1099, 53, 2947, 1064, 256, 517, 1919, 2683, 3598, 518, 2510, 2843, 4859, 4569, 85, 2281, 4977, 3098, 4781, 966, 4313, 1555, 3833, 3863, 267, 3149, 2985, 3611, 3849, 1566, 4002, 2202, 3114, 4804, 2739, 1459, 3776, 1293, 3784, 2197, 4175, 3368, 3467, 1131, 3382, 2305, 480, 3804, 2769, 1816, 2301, 3322, 1738, 3682, 3438, 3441, 3704, 4637, 2830, 4536, 3066, 2827, 2986, 4677, 4759, 1238, 4609, 983, 4321, 3778, 909, 3671, 55, 2679, 3928, 4336, 2295, 4498, 2326, 2791, 864, 3775, 1809, 365, 3701, 1080, 4215, 3902, 985, 894, 313, 940, 2754, 1667, 4507, 487, 3372, 2424, 3564, 3992, 1670, 235, 1246, 4037, 4653, 345, 4128, 377, 1933, 4758, 683, 1727, 3250, 4679, 1188, 4096, 764, 1309, 977, 1139, 841, 4482, 2100, 2501, 796, 4380, 4093, 1071, 2935, 2909, 1398, 3746, 3211, 1297, 3576, 3605, 3957, 3772, 1765, 3707, 446, 1531, 2937, 2910, 2099, 3532, 3053, 3693, 4035, 4095, 4987, 581, 3940, 4570, 661, 2904, 462, 2973, 2145, 3975, 4961, 1486, 4117, 1696, 2767, 4209, 373, 691, 3073, 4786, 3798, 4797, 391, 1032, 1393, 2601, 2402, 1489, 1128, 3359, 2620, 477, 3921, 2406, 4960, 1052, 3207, 4155, 2855, 100, 1920, 596, 3157, 4063, 2780, 2831, 4802, 4628, 1330, 557, 2461, 3265, 3623, 4372, 3743, 1693, 1533, 3193, 55, 4085, 2873, 1570, 1272, 90, 2251, 2542, 1911, 1263, 2554, 1608, 4295, 3034, 3639, 26, 726, 830, 1927, 1676, 2525, 3302, 1034, 4616, 4539, 1882, 2330, 705, 2632, 4354, 2260, 4092, 828, 2213, 4302, 611, 2527, 2979, 1081, 4979, 3468, 1324, 4148, 864, 3944, 1679, 4415, 1913, 4915, 4694, 4049, 514, 1401, 3144, 1754, 4012, 1050, 2469, 959, 1986, 776, 889, 3349, 1820, 3712, 4678, 1330, 1112, 2589, 3303, 1715, 3247, 784, 4517, 4925, 1916, 2296, 1205, 2242, 881, 3575, 3406, 2772, 2223, 3521, 3855, 4779, 953, 1526, 701, 3939, 945, 571, 3842, 3311, 4584, 2065, 3423, 1656, 3766, 1948, 835, 573, 4438, 568, 1184, 4983, 3725, 4280, 3659, 2356, 2275, 3896, 3191, 1517, 2092, 4670, 4408, 4892, 4795, 1993, 1825, 2619, 4927, 643, 2547, 1419, 2590, 4137, 2188, 4930, 919, 64, 2436, 551, 3004, 4350, 1018, 4805, 1957, 4859, 243, 2144, 2160, 1962, 4838, 1048, 151, 2456, 4154, 1949, 3148, 3444, 2736, 174, 1163, 3202, 1330, 3591, 1021, 2896, 1872, 932, 3063, 999, 4546, 4571, 1635, 3046, 2905, 67, 4188, 1035, 968, 3817, 1905, 314, 2662, 3087, 3544, 1607, 2800, 677, 4858, 4925, 4322, 113, 4272, 1910, 4885, 2672, 2158, 24, 3464, 3507, 2512, 94, 2674, 4287, 287, 341, 638, 3434, 987, 329, 2128, 2141, 1260, 4905, 2325, 3009, 2852, 2048, 3825, 2685, 1353, 2505, 3743, 3061, 2131, 4045, 4415, 4348, 1540, 3998, 1240, 2619, 3132, 3620, 1007, 2873, 2781, 1192, 2296, 1048, 3084, 4316, 4358, 3155, 4739, 344, 1484, 1953, 1181, 3699, 2571, 3082, 2223, 4929, 1890, 87, 642, 3248, 3427, 164, 1657, 3298, 3540, 4062, 2571, 1434, 3124, 1682, 222, 2569, 915, 3048, 1585, 4080, 3092, 452, 1232, 874, 3070, 2479, 3900, 611, 1044, 3721, 2158, 80, 1365, 4001, 3683, 4375, 3493, 4373, 1304, 62, 2555, 199, 2682, 850, 745, 3366, 1289, 2134, 3948, 603, 1711, 4076, 4042, 501, 3990, 4698, 1752, 1617, 3919, 2691, 212, 2774, 316, 3581, 1795, 3909, 912, 4423, 2672, 724, 1843, 1967, 3451, 1293, 130, 1015, 4818, 3395, 853, 4135, 1806, 2144, 1507, 3158, 4639, 3511, 755, 1458, 1364, 4276, 415, 761, 1083, 3963, 552, 3422, 3293, 3610, 3733, 3440, 1939, 17, 1220, 216, 550, 549, 3417, 3179, 2242, 2549, 1283, 2319, 4012, 2806, 1335, 2327, 22, 798, 2470, 4174, 1075, 4242, 3025, 1570, 4101, 218, 2104, 2404, 3381, 4025, 3326, 3499, 2852, 4942, 2988, 2890, 4544, 2562, 2160, 1282, 4907, 2583, 1111, 1193, 3610, 3336, 3491, 2536, 3258, 1468, 2380, 2589, 4494, 1763, 4817, 2594, 2662, 3521, 4759, 1132, 1221, 343, 4467, 2976, 4756, 3684, 2007, 2616, 2102, 4941, 238, 2709, 199, 284, 3969, 3488, 1269, 3550, 3505, 4105, 303, 1729, 2591, 2847, 1954, 3247, 548, 3245, 3945, 1867, 4976, 4520, 3692, 4790, 3027, 2356, 2633, 3143, 4671, 1922, 4002, 2934, 2564, 3380, 954, 1078, 2147, 393, 4793, 1260, 4548, 2871, 3502, 4842, 1283, 4345, 1498, 3297, 4340, 1644, 2848, 2208, 2249, 4461, 4338, 581, 1712, 4588, 4965, 4841, 3408, 3299, 3530, 4645, 2407, 1851, 3857, 755, 3892, 962, 710, 4712, 4800, 4780, 4008, 1460, 2257, 3898, 368, 1435, 2016, 2189, 4483, 2798, 2561, 2106, 1678, 3516, 3580, 1108, 3576, 2363, 2881, 4927, 3669, 2878, 3126, 3554, 1176, 377, 389, 597, 2719, 334, 4697, 2973, 3555, 2730, 3857, 2530, 4595, 4890, 4133, 3381, 4852, 3270, 4189, 1031, 982, 3487, 2814, 2534, 2259, 3275, 4422, 209, 3485, 4464, 1026, 3341, 3078, 4880, 4834, 3819, 4419, 2708, 708, 3576, 3894, 2125, 107, 1319, 1077, 4968, 2911, 2393, 3505, 3390, 1842, 1036, 4609, 3350, 3101, 956, 1207, 417, 581, 1258, 3610, 129, 2853, 3814, 4155, 4499, 2138, 3085, 2141, 2320, 4949, 1775, 4578, 217, 315, 1236, 1784, 781, 3113, 1701, 4177, 4239, 264, 202, 501, 967, 869, 3942, 330, 368, 4294, 4535, 1917, 1973, 2197, 3659, 3099, 4220, 2402, 4941, 3440, 1694, 1934, 1564, 3063, 3331, 3662 }, 1231);
        }

        public int Calculate(int[,] dp, int[] prices, int i, int j, int fee)
        {
            if (j - 1 == 1) return Math.Max(0, prices[j] - prices[i] - fee);
            else
            {
                int max = 0;
                for (int k = i; k < j; k++)
                {
                    int left = dp[i, k];
                    int right = dp[k + 1, j];

                    max = Math.Max(max, left + right);
                }

                return Math.Max(max, prices[j] - prices[i] - fee);
            }
        }

        //TLE
        public int MaxProfit_2(int[] prices, int fee)
        {
            int length = prices.Length;
            int[,] dp = new int[length, length];

            for (int i = 0; i < length; i++)
            {
                dp[i, i] = 0;
            }

            for (int k = 1; k < length; k++)
            {
                for (int i = 0; i < length - k; i++)
                {
                    int j = i + k;
                    dp[i, j] = Calculate(dp, prices, i, j, fee);
                }
            }

            return dp[0, length - 1];
        }
    }
}
