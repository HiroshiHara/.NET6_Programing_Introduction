using System.Reflection;
using System.Collections.Generic;

namespace csconsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var hello = new Hello()
            {
                Name = "Hara Hiroshi"
            };
            var attr1 = typeof(Hello).GetProperty("Name").GetCustomAttribute<HelpAttribute>();
            Console.WriteLine(attr1?.Message); // expected out:ここで名前を入力
            Console.WriteLine(hello.Name);

            var attr2 = typeof(Hello).GetMethod("Print").GetCustomAttribute<HelpAttribute>();
            Console.WriteLine(attr2?.Message); // expected out:ここで挨拶を表示する
            hello.Print();

            var kv = new GenericSample<int, string>();
            kv.Add(1, "adam");
            kv.Add(2, "bob");
            kv.Add(3, "chris");
            kv.Add(4, "dom");
            kv.PrintAll();

        }
    }

    internal class HelpAttribute : Attribute
    {
        public string Message { get; set; }
        public HelpAttribute(string msg)
        {
            this.Message = msg;
        }
    }

    internal class Hello
    {
        [Help("ここに名前を入力")]
        public string Name { get; set; } = "";

        [Help("ここで挨拶を表示する")]
        public void Print()
        {
            Console.WriteLine($"Hello {this.Name}");
        }
    }

    internal class GenericSample<TKey, TValue>
    {
        private class KV
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public KV (TKey key, TValue value)
            {
                this.Key = key;
                this.Value = value;
            }
        }

        private List<KV> _list = new List<KV>();

        public TValue? GetValue(TKey key)
        {
            foreach(var item in _list)
            {
                if (item.Key!.Equals(key))
                {
                    return item.Value;
                }
            }
            // default(型)でTValueの型に応じたデフォルト値を返却する
            return default(TValue);
        }

        public void Add(TKey key, TValue value)
        {
            foreach(var item in _list)
            {
                if (item.Key!.Equals(key))
                {
                    item.Value = value;
                    return;
                }
            }
            _list.Add(new KV(key, value));
        }

        public void PrintAll()
        {
            foreach (var item in _list)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }

}