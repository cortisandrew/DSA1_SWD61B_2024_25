using ADTs_and_DSs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs_and_DSs.ABV
{
    public class ArrayBasedVector<T> : IVectorADT<T>
    {
        public int Count()
        {
            throw new NotImplementedException();
        }

        public T GetElementAtRank(int rank)
        {
            throw new NotImplementedException();
        }

        public void InsertElementAtRank(int rank, T element)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public T RemoveElementAtRank(int rank)
        {
            throw new NotImplementedException();
        }

        public T ReplaceElementAtRank(int rank, T newElement)
        {
            throw new NotImplementedException();
        }
    }
}
