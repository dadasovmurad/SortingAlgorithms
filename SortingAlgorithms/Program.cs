namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };
            ISortingService<int> sortingService = new SelectionSortManager<int>();
            var sortingResult = sortingService.SortArray(numbers);
        }
    }
}