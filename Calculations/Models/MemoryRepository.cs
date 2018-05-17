using System.Collections.Generic;

namespace Calculations.Models {

    public class MemoryRepository : IRepository {

        private Dictionary<int, CalculationResult> items;

        public MemoryRepository() {
            items = new Dictionary<int, CalculationResult>();
            new List<CalculationResult> {
                new CalculationResult { OperationName = "Add",      Result = "1",   num1 = 0, num2 = 1 },
                new CalculationResult { OperationName = "Multiply", Result = "2",   num1 = 1, num2 = 2 },
                new CalculationResult { OperationName = "Compare",  Result = "0" ,  num1 = 1, num2 = 1 }
            }.ForEach(r => AddResult(r));
        }

        public CalculationResult this[int id] => items.ContainsKey(id) ? items[id] : null;

        public IEnumerable<CalculationResult> Results => items.Values;

        public int AddResult(CalculationResult result)
        {
            int key = items.Count;
            while (items.ContainsKey(key)) { key++; };
            

            items.Add(key, result);

            return key;
        }

        public void DeleteResult(int id) => items.Remove(id);

    }
}
