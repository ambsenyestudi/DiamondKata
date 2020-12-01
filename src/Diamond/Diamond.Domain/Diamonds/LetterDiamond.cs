using Diamond.Domain.Rows;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Diamond.Domain.Diamonds
{

    public class LetterDiamond:IEqualityComparer<LetterDiamond> 
    {
        public List<DiamondRow> RowList { get; }

        public LetterDiamond(List<DiamondRow> rowList)
        {
            if(rowList == null)
            {
                throw new ArgumentException($"{nameof(rowList)} cann not be null alt {nameof(LetterDiamond)} constructor");
            }
            RowList = rowList;
        }


        public bool Equals(LetterDiamond diamond, LetterDiamond other)
        {
            if(diamond == null)
            {
                return other == null;
            }
            if(other == null)
            {
                return diamond == null;
            }
            var diamondRowCount = diamond.RowList.Count;
            if (diamondRowCount != other.RowList.Count)
            {
                return false;
            }
            for (int i = 0; i < diamondRowCount; i++)
            {
                DiamondRow diamondRow = diamond.RowList[i];
                DiamondRow otherDiamondRow = other.RowList[i];
                if (!diamondRow.Equals(otherDiamondRow))
                {
                    return false;
                }
            }
            return true;
        }
        public override bool Equals(object obj)
        {
            if(obj==null || obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals(this, (LetterDiamond)obj);
        }

        public int GetHashCode([DisallowNull] LetterDiamond obj) =>
            obj.RowList.GetHashCode();

        
    }
}
