﻿using System;

namespace NullableDirective
{
    class EnableWarnings
    {
        public void Run()
        {
#nullable disable
            ;
#nullable enable warnings
            int i1 = null; // error CS0037: Null 非許容の値型であるため、Null を 'int' に変換できません
            int? i2 = null;
            string s1 = null;
            string? s2 = null; // warning CS8632: '#nullable' 注釈コンテキスト内のコードでのみ、Null 許容参照型の注釈を使用する必要があります。
            string s3 = null!;
            Console.WriteLine($"{i1}, {i2}, {s1}, {s2}, {s3}");

            string? s4 = (new Random().Next(0, 2) == 0) ? null : "A"; // nullかもしれない
            Console.WriteLine($"{s4}");
            Console.WriteLine($"{s4!}");
            if (null != s4) { // nullでない
                Console.WriteLine($"{s4}"); // 逆参照。非nullであることが確実だから警告を消したい。
                Console.WriteLine($"{s4!}"); // 逆参照。非nullであることが確実だから警告を消したい。null免除演算子を使う
            } else { // nullである
                Console.WriteLine($"{s4}"); // 逆参照。非nullであることが確実だから警告を消したい。
                Console.WriteLine($"{s4!}"); // 逆参照。非nullであることが確実だから警告を消したい。null免除演算子を使う
            }
        }
    }
}
