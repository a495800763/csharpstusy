using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Collections
{
    /// <summary>
    /// 继承CollectionBase 类实现Animal类对象的集合类
    /// </summary>
    public class Animals : CollectionBase 
    {
        public void Add(Animal newAnimal)
        {
            List.Add(newAnimal);
        }

        public void  Remove(Animal newAnimal)
        {
            List.Remove(newAnimal);
        }

        //定义索引符
        public Animal this[int animalIndex]
        {
            get
            {
                return (Animal)List[animalIndex];
            }
            set
            {
                List[animalIndex] = value;
            }
        }
    }
}
