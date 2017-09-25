/*
 * Сделано в SharpDevelop.
 * Пользователь: suvoroda
 * Дата: 17.09.2017
 * Время: 17:16
 */
using System;
using System.Collections.Generic;

namespace ComLibTools.Entityes
{
	/// <summary>
	/// Description of ACommand.
	/// </summary>
	public abstract class ACommand
	{
		public String Name;
		public int CountArgs;
		public List<String> Arguments;
		public abstract void Execute();
		public abstract void setArgs(List<String> args);
	}
}
