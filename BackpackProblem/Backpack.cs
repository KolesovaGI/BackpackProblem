using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackProblem
{
	/// <summary>
	/// Класс, реализующий логику задачи
	/// </summary>
    public class Backpack
    {
		/// <summary>
		/// Реализация логики вычисления проблемы рюкзака
		/// </summary>
		/// <param name="bagCapacity">Вместимость рюкзака</param>
		/// <param name="items">Список с предметами</param>
		/// <returns>Матрица лучших значений</returns>
        public int Calculate(int bagCapacity, List<Item> items)
        {
			var itemCount = items.Count;										// Количество предметов
			int[,] matrix = new int[itemCount + 1, bagCapacity + 1];			// Матрица для рюкзака

			for (int i = 0; i <= itemCount; i++)								// Проход всем предметам
			{
				for (int w = 0; w <= bagCapacity; w++)
				{
					if (i == 0 || w == 0)
					{
						matrix[i, w] = 0;
						continue;
					}

					var currentJewelIndex = i - 1;								// Индексы начинаются с нуля
					var currentJewel = items[currentJewelIndex];				// Чтение во избежание ошибки
 
					if (currentJewel.Weigth <= w)								// Если вес предмета меньше веса рюкзака
					{
						matrix[i, w] = Math.Max(currentJewel.Price				// Поиск лучшей комбинации предметов
							+ matrix[i - 1, w - currentJewel.Weigth], 
							matrix[i - 1, w]);
					}
                    
                    else                                                        // Если вес предметов больше веса рюкзака
                    {
						matrix[i, w] = matrix[i - 1, w];						// Вернуть последнюю лучшую комбинацию
					}
				}
			}

			return matrix[itemCount, bagCapacity];                              // Последний пунк в обоих индексах - maxval, т.к. всё продвигается вперёд
		}
    }
}
