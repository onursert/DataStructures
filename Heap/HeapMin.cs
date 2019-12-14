using System;

namespace heapMin
{
    class HeapMin
    {
        int[] heap;
        int count = 0;

        public HeapMin(int size)
        {
            heap = new int[size];
        }

        //----------
        private int getLeftChildIndex(int parentIndex)
        {
            return parentIndex * 2 + 1;
        }

        private int getRightChildIndex(int parentIndex)
        {
            return parentIndex * 2 + 2;
        }

        private int getParentIndex(int childIndex)
        {
            return (childIndex - 1) / 2;
        }

        //----------
        private bool hasLeftChild(int index)
        {
            return getLeftChildIndex(index) < count;
        }

        private bool hasRightChild(int index)
        {
            return getRightChildIndex(index) < count;
        }

        private bool hasParent(int index)
        {
            return getParentIndex(index) >= 0;
        }

        //----------
        private int leftChild(int index)
        {
            return heap[getLeftChildIndex(index)];
        }

        private int rightChild(int index)
        {
            return heap[getRightChildIndex(index)];
        }

        private int parent(int index)
        {
            return heap[getParentIndex(index)];
        }

        //----------
        private void Swap(int index1, int index2)
        {
            int temp = heap[index1];
            heap[index1] = heap[index2];
            heap[index2] = temp;
        }

        private void EnsureMaxCapacity()
        {
            if (count == heap.Length)
            {
                int[] resizedHeap = new int[heap.Length * 2];
                //heap.CopyTo(heapResized, 0);
                Array.Copy(heap, 0, resizedHeap, 0, count);
                heap = resizedHeap;
            }
        }

        private void EnsureMinCapacity()
        {
            if (count * 4 < heap.Length)
            {
                int[] resizedHeap = new int[heap.Length / 2];
                Array.Copy(heap, 0, resizedHeap, 0, count);
                heap = resizedHeap;
            }
        }

        //----------
        public int Front()
        {
            if (count == 0)
            {
                return -1;
            }

            return heap[0];
        }

        public int Remove()
        {
            if (count == 0)
            {
                return -1;
            }

            int removedItem = heap[0];
            heap[0] = heap[count - 1];
            count--;
            HeapifyDown();
            EnsureMinCapacity();
            return removedItem;
        }

        public void Add(int value)
        {
            EnsureMaxCapacity();

            heap[count] = value;
            count++;
            HeapifyUp();
        }

        private void HeapifyDown()
        {
            int lastRemovedValueIndex = 0;
            while (hasLeftChild(lastRemovedValueIndex))
            {
                int smallerChildIndex = getLeftChildIndex(lastRemovedValueIndex);
                if (hasRightChild(lastRemovedValueIndex) && rightChild(lastRemovedValueIndex) < leftChild(lastRemovedValueIndex))
                {
                    smallerChildIndex = getRightChildIndex(lastRemovedValueIndex);
                }

                if (heap[lastRemovedValueIndex] < heap[smallerChildIndex])
                {
                    break;
                }
                else
                {
                    Swap(lastRemovedValueIndex, smallerChildIndex);
                    lastRemovedValueIndex = smallerChildIndex;
                }
            }
        }

        private void HeapifyUp()
        {
            int lastAddedValueIndex = count - 1;
            while (hasParent(lastAddedValueIndex) && parent(lastAddedValueIndex) > heap[lastAddedValueIndex])
            {
                Swap(lastAddedValueIndex, getParentIndex(lastAddedValueIndex));
                lastAddedValueIndex = getParentIndex(lastAddedValueIndex);
            }
        }
    }
}
