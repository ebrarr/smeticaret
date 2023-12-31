﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Shared.ServiceResult
{

	public interface IServiceResult
	{
		bool IsSuccess { get; }
		string? Message { get; }
		int StatusCode { get; }
	}

	public interface IServiceResult<out T> : IServiceResult
	{
		T? Data { get; }
	}

}
