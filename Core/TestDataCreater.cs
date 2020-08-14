using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
	public static class TestDataCreater
	{
		public static string GetWheatherJSONSTR()
		{
			return @" {
    ""lat"": 36.9,
	""lon"": 31,
	""timezone"": ""Europe/Istanbul"",
	""timezone_offset"": 10800,
	""current"": {
					""dt"": 1591045255,
		""sunrise"": 1591065478,
		""sunset"": 1591117826,
		""temp"": 289.15,
		""feels_like"": 286.29,
		""pressure"": 1009,
		""humidity"": 67,
		""dew_point"": 283.03,
		""uvi"": 9.11,
		""clouds"": 31,
		""visibility"": 10000,
		""wind_speed"": 4.1,
		""wind_deg"": 320,
		""weather"": [
			{
						""id"": 802,
				""main"": ""Clouds"",
				""description"": ""scattered clouds"",
				""icon"": ""03n""
			}
		]
	},
	""hourly"": [
		{
					""dt"": 1591045200,
			""temp"": 289.15,
			""feels_like"": 286,
			""pressure"": 1009,
			""humidity"": 67,
			""dew_point"": 283.03,
			""clouds"": 31,
			""wind_speed"": 4.52,
			""wind_deg"": 334,
			""weather"": [
				{
						""id"": 802,
					""main"": ""Clouds"",
					""description"": ""scattered clouds"",
					""icon"": ""03n""
				}
			]
		},
		{
					""dt"": 1591048800,
			""temp"": 290.01,
			""feels_like"": 287.03,
			""pressure"": 1009,
			""humidity"": 63,
			""dew_point"": 282.93,
			""clouds"": 39,
			""wind_speed"": 4.23,
			""wind_deg"": 339,
			""weather"": [
				{
						""id"": 802,
					""main"": ""Clouds"",
					""description"": ""scattered clouds"",
					""icon"": ""03n""
				}
			]
		},
		{
					""dt"": 1591052400,
			""temp"": 290.5,
			""feels_like"": 287.74,
			""pressure"": 1008,
			""humidity"": 61,
			""dew_point"": 282.91,
			""clouds"": 51,
			""wind_speed"": 3.91,
			""wind_deg"": 342,
			""weather"": [
				{
						""id"": 803,
					""main"": ""Clouds"",
					""description"": ""broken clouds"",
					""icon"": ""04n""
				}
			]
		},
		{
					""dt"": 1591056000,
			""temp"": 290.61,
			""feels_like"": 288.05,
			""pressure"": 1008,
			""humidity"": 61,
			""dew_point"": 283.02,
			""clouds"": 53,
			""wind_speed"": 3.66,
			""wind_deg"": 346,
			""weather"": [
				{
						""id"": 803,
					""main"": ""Clouds"",
					""description"": ""broken clouds"",
					""icon"": ""04n""
				}
			]
		},
		{
					""dt"": 1591059600,
			""temp"": 290.39,
			""feels_like"": 288.24,
			""pressure"": 1008,
			""humidity"": 63,
			""dew_point"": 283.29,
			""clouds"": 10,
			""wind_speed"": 3.18,
			""wind_deg"": 358,
			""weather"": [
				{
						""id"": 500,
					""main"": ""Rain"",
					""description"": ""light rain"",
					""icon"": ""10n""
				}
			],
			""rain"": {
						""1h"": 0.11
			}
				},
		{
					""dt"": 1591063200,
			""temp"": 290.15,
			""feels_like"": 288.38,
			""pressure"": 1008,
			""humidity"": 65,
			""dew_point"": 283.58,
			""clouds"": 6,
			""wind_speed"": 2.74,
			""wind_deg"": 5,
			""weather"": [
				{
						""id"": 500,
					""main"": ""Rain"",
					""description"": ""light rain"",
					""icon"": ""10n""
				}
			],
			""rain"": {
						""1h"": 0.11
			}
				},
		{
					""dt"": 1591066800,
			""temp"": 290.06,
			""feels_like"": 288.43,
			""pressure"": 1007,
			""humidity"": 66,
			""dew_point"": 283.89,
			""clouds"": 4,
			""wind_speed"": 2.59,
			""wind_deg"": 4,
			""weather"": [
				{
						""id"": 500,
					""main"": ""Rain"",
					""description"": ""light rain"",
					""icon"": ""10d""
				}
			],
			""rain"": {
						""1h"": 0.19
			}
				},
		{
					""dt"": 1591070400,
			""temp"": 291.43,
			""feels_like"": 289.91,
			""pressure"": 1007,
			""humidity"": 64,
			""dew_point"": 284.58,
			""clouds"": 3,
			""wind_speed"": 2.78,
			""wind_deg"": 354,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01d""
				}
			]
		},
		{
					""dt"": 1591074000,
			""temp"": 293.35,
			""feels_like"": 292.03,
			""pressure"": 1007,
			""humidity"": 56,
			""dew_point"": 284.48,
			""clouds"": 3,
			""wind_speed"": 2.41,
			""wind_deg"": 345,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01d""
				}
			]
		},
		{
					""dt"": 1591077600,
			""temp"": 294.93,
			""feels_like"": 294.69,
			""pressure"": 1007,
			""humidity"": 51,
			""dew_point"": 284.42,
			""clouds"": 5,
			""wind_speed"": 0.89,
			""wind_deg"": 355,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01d""
				}
			]
		},
		{
					""dt"": 1591081200,
			""temp"": 295.74,
			""feels_like"": 295.09,
			""pressure"": 1007,
			""humidity"": 48,
			""dew_point"": 284.36,
			""clouds"": 8,
			""wind_speed"": 1.4,
			""wind_deg"": 156,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01d""
				}
			]
		},
		{
					""dt"": 1591084800,
			""temp"": 296.38,
			""feels_like"": 294.82,
			""pressure"": 1007,
			""humidity"": 47,
			""dew_point"": 284.62,
			""clouds"": 5,
			""wind_speed"": 2.81,
			""wind_deg"": 167,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01d""
				}
			]
		},
		{
					""dt"": 1591088400,
			""temp"": 296.92,
			""feels_like"": 294.5,
			""pressure"": 1007,
			""humidity"": 46,
			""dew_point"": 284.9,
			""clouds"": 7,
			""wind_speed"": 4.1,
			""wind_deg"": 173,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01d""
				}
			]
		},
		{
					""dt"": 1591092000,
			""temp"": 296.79,
			""feels_like"": 294.03,
			""pressure"": 1006,
			""humidity"": 47,
			""dew_point"": 284.91,
			""clouds"": 25,
			""wind_speed"": 4.68,
			""wind_deg"": 177,
			""weather"": [
				{
						""id"": 802,
					""main"": ""Clouds"",
					""description"": ""scattered clouds"",
					""icon"": ""03d""
				}
			]
		},
		{
					""dt"": 1591095600,
			""temp"": 297.03,
			""feels_like"": 293.87,
			""pressure"": 1006,
			""humidity"": 47,
			""dew_point"": 285.11,
			""clouds"": 24,
			""wind_speed"": 5.35,
			""wind_deg"": 181,
			""weather"": [
				{
						""id"": 801,
					""main"": ""Clouds"",
					""description"": ""few clouds"",
					""icon"": ""02d""
				}
			]
		},
		{
					""dt"": 1591099200,
			""temp"": 296.95,
			""feels_like"": 294.01,
			""pressure"": 1006,
			""humidity"": 48,
			""dew_point"": 285.36,
			""clouds"": 21,
			""wind_speed"": 5.14,
			""wind_deg"": 175,
			""weather"": [
				{
						""id"": 801,
					""main"": ""Clouds"",
					""description"": ""few clouds"",
					""icon"": ""02d""
				}
			]
		},
		{
					""dt"": 1591102800,
			""temp"": 296.83,
			""feels_like"": 294.07,
			""pressure"": 1006,
			""humidity"": 48,
			""dew_point"": 285.43,
			""clouds"": 4,
			""wind_speed"": 4.83,
			""wind_deg"": 166,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01d""
				}
			]
		},
		{
					""dt"": 1591106400,
			""temp"": 296.47,
			""feels_like"": 293.89,
			""pressure"": 1006,
			""humidity"": 50,
			""dew_point"": 285.6,
			""clouds"": 2,
			""wind_speed"": 4.71,
			""wind_deg"": 165,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01d""
				}
			]
		},
		{
					""dt"": 1591110000,
			""temp"": 295.82,
			""feels_like"": 293.81,
			""pressure"": 1006,
			""humidity"": 53,
			""dew_point"": 285.85,
			""clouds"": 2,
			""wind_speed"": 4.02,
			""wind_deg"": 163,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01d""
				}
			]
		},
		{
					""dt"": 1591113600,
			""temp"": 295.01,
			""feels_like"": 293.79,
			""pressure"": 1006,
			""humidity"": 57,
			""dew_point"": 286.14,
			""clouds"": 2,
			""wind_speed"": 3.06,
			""wind_deg"": 145,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01d""
				}
			]
		},
		{
					""dt"": 1591117200,
			""temp"": 293.36,
			""feels_like"": 292.82,
			""pressure"": 1006,
			""humidity"": 64,
			""dew_point"": 286.54,
			""clouds"": 2,
			""wind_speed"": 2.19,
			""wind_deg"": 121,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01d""
				}
			]
		},
		{
					""dt"": 1591120800,
			""temp"": 292.39,
			""feels_like"": 291.86,
			""pressure"": 1007,
			""humidity"": 68,
			""dew_point"": 286.45,
			""clouds"": 1,
			""wind_speed"": 2.18,
			""wind_deg"": 89,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01n""
				}
			]
		},
		{
					""dt"": 1591124400,
			""temp"": 292.03,
			""feels_like"": 291.15,
			""pressure"": 1008,
			""humidity"": 69,
			""dew_point"": 286.41,
			""clouds"": 0,
			""wind_speed"": 2.62,
			""wind_deg"": 69,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01n""
				}
			]
		},
		{
					""dt"": 1591128000,
			""temp"": 291.68,
			""feels_like"": 290.63,
			""pressure"": 1008,
			""humidity"": 71,
			""dew_point"": 286.34,
			""clouds"": 0,
			""wind_speed"": 2.91,
			""wind_deg"": 63,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01n""
				}
			]
		},
		{
					""dt"": 1591131600,
			""temp"": 291.36,
			""feels_like"": 290.45,
			""pressure"": 1008,
			""humidity"": 72,
			""dew_point"": 286.28,
			""clouds"": 0,
			""wind_speed"": 2.67,
			""wind_deg"": 62,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01n""
				}
			]
		},
		{
					""dt"": 1591135200,
			""temp"": 291.02,
			""feels_like"": 290.15,
			""pressure"": 1008,
			""humidity"": 73,
			""dew_point"": 286.22,
			""clouds"": 0,
			""wind_speed"": 2.55,
			""wind_deg"": 55,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01n""
				}
			]
		},
		{
					""dt"": 1591138800,
			""temp"": 290.8,
			""feels_like"": 289.79,
			""pressure"": 1008,
			""humidity"": 73,
			""dew_point"": 286.08,
			""clouds"": 0,
			""wind_speed"": 2.66,
			""wind_deg"": 53,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01n""
				}
			]
		},
		{
					""dt"": 1591142400,
			""temp"": 290.66,
			""feels_like"": 289.82,
			""pressure"": 1007,
			""humidity"": 73,
			""dew_point"": 285.91,
			""clouds"": 0,
			""wind_speed"": 2.35,
			""wind_deg"": 48,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01n""
				}
			]
		},
		{
					""dt"": 1591146000,
			""temp"": 290.66,
			""feels_like"": 289.81,
			""pressure"": 1007,
			""humidity"": 72,
			""dew_point"": 285.68,
			""clouds"": 0,
			""wind_speed"": 2.27,
			""wind_deg"": 31,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01n""
				}
			]
		},
		{
					""dt"": 1591149600,
			""temp"": 290.47,
			""feels_like"": 289.5,
			""pressure"": 1007,
			""humidity"": 71,
			""dew_point"": 285.3,
			""clouds"": 0,
			""wind_speed"": 2.28,
			""wind_deg"": 21,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01n""
				}
			]
		},
		{
					""dt"": 1591153200,
			""temp"": 290.28,
			""feels_like"": 289.48,
			""pressure"": 1008,
			""humidity"": 71,
			""dew_point"": 285.02,
			""clouds"": 0,
			""wind_speed"": 1.96,
			""wind_deg"": 12,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01d""
				}
			]
		},
		{
					""dt"": 1591156800,
			""temp"": 291.57,
			""feels_like"": 290.96,
			""pressure"": 1008,
			""humidity"": 66,
			""dew_point"": 285.12,
			""clouds"": 0,
			""wind_speed"": 1.74,
			""wind_deg"": 1,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01d""
				}
			]
		},
		{
					""dt"": 1591160400,
			""temp"": 293.03,
			""feels_like"": 292.85,
			""pressure"": 1008,
			""humidity"": 60,
			""dew_point"": 285.15,
			""clouds"": 0,
			""wind_speed"": 1.09,
			""wind_deg"": 350,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01d""
				}
			]
		},
		{
					""dt"": 1591164000,
			""temp"": 294.28,
			""feels_like"": 294.38,
			""pressure"": 1008,
			""humidity"": 56,
			""dew_point"": 285.43,
			""clouds"": 0,
			""wind_speed"": 0.74,
			""wind_deg"": 164,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01d""
				}
			]
		},
		{
					""dt"": 1591167600,
			""temp"": 295.16,
			""feels_like"": 294.6,
			""pressure"": 1008,
			""humidity"": 56,
			""dew_point"": 286,
			""clouds"": 0,
			""wind_speed"": 2.05,
			""wind_deg"": 158,
			""weather"": [
				{
						""id"": 800,
					""main"": ""Clear"",
					""description"": ""clear sky"",
					""icon"": ""01d""
				}
			]
		},
		{
					""dt"": 1591171200,
			""temp"": 296.14,
			""feels_like"": 294.88,
			""pressure"": 1009,
			""humidity"": 54,
			""dew_point"": 286.42,
			""clouds"": 29,
			""wind_speed"": 3.22,
			""wind_deg"": 159,
			""weather"": [
				{
						""id"": 802,
					""main"": ""Clouds"",
					""description"": ""scattered clouds"",
					""icon"": ""03d""
				}
			]
		},
		{
					""dt"": 1591174800,
			""temp"": 296.76,
			""feels_like"": 295.05,
			""pressure"": 1009,
			""humidity"": 53,
			""dew_point"": 286.91,
			""clouds"": 19,
			""wind_speed"": 3.99,
			""wind_deg"": 162,
			""weather"": [
				{
						""id"": 801,
					""main"": ""Clouds"",
					""description"": ""few clouds"",
					""icon"": ""02d""
				}
			]
		},
		{
					""dt"": 1591178400,
			""temp"": 297.04,
			""feels_like"": 295.14,
			""pressure"": 1008,
			""humidity"": 54,
			""dew_point"": 287.3,
			""clouds"": 15,
			""wind_speed"": 4.53,
			""wind_deg"": 162,
			""weather"": [
				{
						""id"": 801,
					""main"": ""Clouds"",
					""description"": ""few clouds"",
					""icon"": ""02d""
				}
			]
		},
		{
					""dt"": 1591182000,
			""temp"": 297.2,
			""feels_like"": 295.11,
			""pressure"": 1008,
			""humidity"": 55,
			""dew_point"": 287.67,
			""clouds"": 12,
			""wind_speed"": 5.01,
			""wind_deg"": 159,
			""weather"": [
				{
						""id"": 801,
					""main"": ""Clouds"",
					""description"": ""few clouds"",
					""icon"": ""02d""
				}
			]
		},
		{
					""dt"": 1591185600,
			""temp"": 296.99,
			""feels_like"": 294.87,
			""pressure"": 1008,
			""humidity"": 56,
			""dew_point"": 287.92,
			""clouds"": 15,
			""wind_speed"": 5.1,
			""wind_deg"": 154,
			""weather"": [
				{
						""id"": 801,
					""main"": ""Clouds"",
					""description"": ""few clouds"",
					""icon"": ""02d""
				}
			]
		},
		{
					""dt"": 1591189200,
			""temp"": 296.87,
			""feels_like"": 294.69,
			""pressure"": 1008,
			""humidity"": 57,
			""dew_point"": 287.99,
			""clouds"": 47,
			""wind_speed"": 5.26,
			""wind_deg"": 161,
			""weather"": [
				{
						""id"": 802,
					""main"": ""Clouds"",
					""description"": ""scattered clouds"",
					""icon"": ""03d""
				}
			]
		},
		{
					""dt"": 1591192800,
			""temp"": 296.42,
			""feels_like"": 294.91,
			""pressure"": 1008,
			""humidity"": 59,
			""dew_point"": 288.13,
			""clouds"": 68,
			""wind_speed"": 4.36,
			""wind_deg"": 169,
			""weather"": [
				{
						""id"": 803,
					""main"": ""Clouds"",
					""description"": ""broken clouds"",
					""icon"": ""04d""
				}
			]
		},
		{
					""dt"": 1591196400,
			""temp"": 295.96,
			""feels_like"": 294.99,
			""pressure"": 1009,
			""humidity"": 61,
			""dew_point"": 288.14,
			""clouds"": 79,
			""wind_speed"": 3.64,
			""wind_deg"": 167,
			""weather"": [
				{
						""id"": 803,
					""main"": ""Clouds"",
					""description"": ""broken clouds"",
					""icon"": ""04d""
				}
			]
		},
		{
					""dt"": 1591200000,
			""temp"": 295.04,
			""feels_like"": 294.18,
			""pressure"": 1009,
			""humidity"": 66,
			""dew_point"": 288.64,
			""clouds"": 84,
			""wind_speed"": 3.67,
			""wind_deg"": 162,
			""weather"": [
				{
						""id"": 803,
					""main"": ""Clouds"",
					""description"": ""broken clouds"",
					""icon"": ""04d""
				}
			]
		},
		{
					""dt"": 1591203600,
			""temp"": 293.87,
			""feels_like"": 293.51,
			""pressure"": 1010,
			""humidity"": 72,
			""dew_point"": 288.77,
			""clouds"": 87,
			""wind_speed"": 3.07,
			""wind_deg"": 151,
			""weather"": [
				{
						""id"": 804,
					""main"": ""Clouds"",
					""description"": ""overcast clouds"",
					""icon"": ""04d""
				}
			]
		},
		{
					""dt"": 1591207200,
			""temp"": 293.04,
			""feels_like"": 292.96,
			""pressure"": 1010,
			""humidity"": 76,
			""dew_point"": 288.69,
			""clouds"": 89,
			""wind_speed"": 2.7,
			""wind_deg"": 135,
			""weather"": [
				{
						""id"": 804,
					""main"": ""Clouds"",
					""description"": ""overcast clouds"",
					""icon"": ""04n""
				}
			]
		},
		{
					""dt"": 1591210800,
			""temp"": 292.64,
			""feels_like"": 292.8,
			""pressure"": 1011,
			""humidity"": 77,
			""dew_point"": 288.64,
			""clouds"": 100,
			""wind_speed"": 2.26,
			""wind_deg"": 113,
			""weather"": [
				{
						""id"": 804,
					""main"": ""Clouds"",
					""description"": ""overcast clouds"",
					""icon"": ""04n""
				}
			]
		},
		{
					""dt"": 1591214400,
			""temp"": 292.26,
			""feels_like"": 292.32,
			""pressure"": 1011,
			""humidity"": 78,
			""dew_point"": 288.52,
			""clouds"": 92,
			""wind_speed"": 2.31,
			""wind_deg"": 88,
			""weather"": [
				{
						""id"": 500,
					""main"": ""Rain"",
					""description"": ""light rain"",
					""icon"": ""10n""
				}
			],
			""rain"": {
						""1h"": 0.11
			}
				}
	]
}";
		}

	}
}
