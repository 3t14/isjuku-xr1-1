/**
 複数行のコメントを
 このように記述することもできます。
 */ 
using System;

namespace xr1_1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// コンソールに初めてのメッセージを出力
			Console.WriteLine("Hello World!");
			// デバッグモードでウインドウを開いた状態にし続ける
			Console.WriteLine("何かキーを入力すると終了します。");
			// 入力待ち状態にする
			Console.ReadKey();
		}
	}
}

