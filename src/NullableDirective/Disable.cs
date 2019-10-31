using System;

namespace NullableDirective
{
    class Disable
    {
        public void Run()
        {
#nullable disable
            int i1 = null; // error CS0037: Null 非許容の値型であるため、Null を 'int' に変換できません
            int? i2 = null;
            string s1 = null;
            string? s2 = null; // warning CS8632: '#nullable' 注釈コンテキスト内のコードでのみ、Null 許容参照型の注釈を使用する必要があります。
            Console.WriteLine($"{i1}, {i2}, {s1}, {s2}");
        }
    }
}
