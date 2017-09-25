/*
 * Сделано в SharpDevelop.
 * Пользователь: suvoroda
 * Дата: 18.09.2017
 * Время: 10:09
 */
using System;
using System.Collections.Generic;
using ComLibTools.Entityes;

namespace ComLibTools
{
	/// <summary>
	/// Description of Command.
	/// </summary>
	public class Command : ACommand
	{
		public static List<String> CommandList = new List<string>();
		public Command(String name, int cntArg)
		{
			base.Name = name;
			base.CountArgs = cntArg;
			if(!CommandList.Contains(name))
				CommandList.Add(name);
		}
		
		public override void setArgs(List<string> args)
		{
			base.Arguments = args;
		}
		
		public override void Execute()
		{
			throw new NotImplementedException("Необходимо создать дочерний класс от текущего и переопределить данный метод.");
		}
	}
}
