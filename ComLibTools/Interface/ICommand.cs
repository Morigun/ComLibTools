/*
 * Сделано в SharpDevelop.
 * Пользователь: suvoroda
 * Дата: 17.09.2017
 * Время: 17:14
 */
using System;
using System.Collections;
using ComLibTools.Entityes;
using System.Collections.Generic;

namespace ComLibTools.Interfaces
{
	/// <summary>
	/// Интерфейс для обработчика команд
	/// </summary>
	public interface IExecutor
	{
		void execute(ACommand command);
		void setArguments(ACommand command, List<String> Args);
	}
}
