using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceExcercise2
{
    public class Stack // LIFO 저장 자료구조
    {
        private List<object> list;
        //public string name;

        public Stack()
        {
            list = new List<object>(5);
        }
        public void Push(object obj) // 데이터를 넣는메서드
        {
            if (obj == null)
            {
                throw new InvalidOperationException($"null은 스택에 추가할 수 없습니다. Null can't be addded in Stack .");
            }
            if (list.Count >= 5)
            {
                throw new InvalidOperationException(" 더 이상 넣을 수 없습니다. Stack is full.");
            }

            list.Add(obj);
            Console.WriteLine($"obj 추가되었습니다. 마지막 obj : {obj}, 현재 count : {list.Count}. obj is added. Last obj : {obj}, Current count : {list.Count}");

        }

        public object Pop() // 데이터를 빼는 메서드 
        {
            if (list.Count == 0) // list = null 
                throw new InvalidOperationException($"스택이 비었습니다. 현재 List : {list}. Stack is empty. Current Stack : {list}");

                var lastIndex = list.Count - 1; // 스택 카운트 - 1 즉, 인덱스값 
                object lastItem = list[lastIndex]; // 스택의 인덱스를 담아줌 즉, 요소(값)
                list.RemoveAt(lastIndex); // 인덱스를 제거 ( 몇번째거 뺄지)
                return lastItem; // 값 반환, 요소 

        }
        public void Clear() // 스택의 모든 요소를 제거하는 메서드 
        {
            list.Clear();
            Console.WriteLine($"스택을 모두 비웠습니다. 현재 count : {list.Count}. Stack is cleared. Current count {list.Count}");
        }
    }
}
