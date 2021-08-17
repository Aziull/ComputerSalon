using BusinessLayer.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;

namespace BusinessLayer.Validators
{
    public class FormFactorValidator
    {
        public bool Validate(ISystemUnitHandler systemUnitHandler)
        {
            var motherboard = (Motherboard)systemUnitHandler.GetDetailByType(DetailType.Motherboard).Select(detail => detail as Detail).FirstOrDefault();
            var unitCase = (Case)systemUnitHandler.GetDetailByType(DetailType.Case).Select(detail => detail as Detail).FirstOrDefault();
            var processor = (Processor)systemUnitHandler.GetDetailByType(DetailType.Processor).Select(detail => detail as Detail).FirstOrDefault();
            var memmoryCard = (MemoryCard)systemUnitHandler.GetDetailByType(DetailType.MemoryCard).Select(detail => detail as Detail).FirstOrDefault();

            if (!unitCase.CheckMotherBoardСompatibility(motherboard) 
                && !motherboard.CheckMemoryCardCompatibility(memmoryCard) 
                && !motherboard.CheckProcessorCompatibility(processor))
                return false;
            return true;
        }
    }
}
