using System.Runtime.CompilerServices;

namespace GenericsConstraints
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="where T : class">T harus merupakan type class bukan type nilai</typeparam>
    /// <typeparam name="IComparable<T>">adalah antarmuka generik yang menyediakan metode</typeparam>
    /// <typeparam name="new()">Memastikan bahwa tipe T harus memiliki konstruktor tanpa parameter (konstruktor default).</typeparam>
    public class Sorter<T> where T : class, IComparable<T>, new()
    {
        // Method untuk melakukan pengurutan
        public void Sort(T[] items)
        {
            // Iterasi melalui array
            for (int i = 1; i < items.Length; i++)
            {
                // bandingkan array ini dengan sebelumnya dengan menggunakan method dari Interface IComparable
                var a = items[i]; // array ke 1
                var b = items[i - 1]; // array ke 0
                if (items[i].CompareTo(items[i - 1]) > 0)
                {
                    // Jika elemen saat ini lebih besar, tukar posisi elemen
                    Swap(items, i, i - 1);
                }
            }
        }

        // Method untuk menukar posisi dua elemen dalam array
        private void Swap(T[] items, int index1, int index2)
        {
            T temp = items[index1];
            items[index1] = items[index2];
            items[index2] = temp;
        }

    }


}