using BusinessLayer.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;

namespace BusinessLayer.Validators
{
    public class FormFactorValidator : IValidator
    {
        public IValidator Next { get; set ; }

        public bool Validate(ISingleUnitService systemUnit)
        {
            var motherboard = (Motherboard)systemUnit.GetDetailByType(DetailType.Motherboard).FirstOrDefault();
            var unitCase = (Case)systemUnit.GetDetailByType(DetailType.Case).FirstOrDefault();
            var processor = (Processor)systemUnit.GetDetailByType(DetailType.Processor).FirstOrDefault();
            var memmoryCard = (MemoryCard)systemUnit.GetDetailByType(DetailType.MemoryCard).FirstOrDefault();

            if (!unitCase.CheckMotherBoardСompatibility(motherboard) 
                && !motherboard.CheckMemoryCardCompatibility(memmoryCard) 
                && !motherboard.CheckProcessorCompatibility(processor))
                return false;
            return Next == null ? true : Next.Validate(systemUnit) ;
        }
    }
}
