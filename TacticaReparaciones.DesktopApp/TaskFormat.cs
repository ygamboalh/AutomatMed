using System.Threading.Tasks;

namespace TacticaReparaciones.DesktopApp
{
    public static class TaskFormat
    {
        public static async Task<(T0, T1)> WhenAll<T0, T1>(Task<T0> task0, Task<T1> task1)
        {
            await Task.WhenAll(task0, task1).ConfigureAwait(false);
            return (task0.Result, task1.Result);
        }

        public static async Task<(T0, T1, T2)> WhenAll<T0, T1, T2>(Task<T0> task0, Task<T1> task1, Task<T2> task2)
        {
            await Task.WhenAll(task0, task1, task2).ConfigureAwait(false);
            return (task0.Result, task1.Result, task2.Result);
        }

        public static async Task<(T0, T1, T2, T3)> WhenAll<T0, T1, T2, T3>(Task<T0> task0, Task<T1> task1, Task<T2> task2, Task<T3> task3)
        {
            await Task.WhenAll(task0, task1, task2).ConfigureAwait(false);
            return (task0.Result, task1.Result, task2.Result, task3.Result);
        }
    }
}
