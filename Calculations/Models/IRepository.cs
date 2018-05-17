using System.Collections.Generic;

namespace Calculations.Models {

    public interface IRepository {

        IEnumerable<CalculationResult> Results { get; }
        CalculationResult this[int id] { get; }

        int AddResult(CalculationResult result);
        void DeleteResult(int id);
    }
}
