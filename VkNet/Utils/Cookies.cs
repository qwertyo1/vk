﻿using System.Collections.Generic;

namespace VkNet.Utils
{
	using System;
	using System.Linq;
	using System.Net;
	using System.Reflection;

	/// <summary>
	/// Cookies
	/// </summary>
	internal sealed class Cookies
	{
		/// <summary>
		/// Получить контейнер Cookies.
		/// </summary>
		public CookieContainer Container { get; }

		/// <summary>
		/// Cookies.
		/// </summary>
		public Cookies()
		{
			Container = new CookieContainer();
		}

		/// <summary>
		/// Добавить из.
		/// </summary>
		/// <param name="responseUrl">URL ответа.</param>
		/// <param name="cookies">Cookies.</param>
		public void AddFrom(Uri responseUrl, CookieCollection cookies)
		{
			foreach (Cookie cookie in cookies) {
				Container.Add(responseUrl, cookie);
			}

			BugFixCookieDomain();
		}

		/// <summary>
		/// Исправление ошибки в домене указанной куки.
		/// </summary>
		private void BugFixCookieDomain()
		{
            //var table =
            //    (Dictionary<string, string>)
            //        Container.GetType()
            //            .InvokeMember("m_domainTable", BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance, null, Container, new object[] { });
            var props = (Dictionary<string, string>)Container.GetType()
                .GetTypeInfo()
                .DeclaredFields
                .Where(x => !x.IsPublic);
            foreach (var key in props
                .Keys
                .ToList())
			{
				if (key[0] != '.')
				{
					continue;
				}

				var newKey = key.Remove(0, 1);
				if (!props.ContainsKey(newKey))
				{
                    props[newKey] = props[key];
				}
			}
		}
    }
}
