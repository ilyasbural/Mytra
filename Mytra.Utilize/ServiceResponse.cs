namespace Mytra.Utilize
{
	public class ServiceResponse<T>
	{
		/// <summary>
		/// İşlem başarılı mı? (true/false)
		/// </summary>
		public bool Success { get; set; }

		/// <summary>
		/// Kullanıcıya veya frontend'e dönecek mesaj
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Tekil entity sonucu
		/// </summary>
		public T Data { get; set; }

		/// <summary>
		/// Liste halinde entity sonuçları
		/// </summary>
		public List<T> DataList { get; set; }

		/// <summary>
		/// Hata mesajları (validation, exception vs.)
		/// </summary>
		public List<string> Errors { get; set; } = new();

		/// <summary>
		/// JWT token (varsa)
		/// </summary>
		public string JwtToken { get; set; }

		/// <summary>
		/// Refresh token (varsa)
		/// </summary>
		public string RefreshToken { get; set; }

		/// <summary>
		/// Ek bilgiler (opsiyonel)
		/// </summary>
		public Dictionary<string, object> Meta { get; set; } = new();

		#region Factory Helpers

		/// <summary>
		/// Tekil entity için başarılı response
		/// </summary>
		public static ServiceResponse<T> SuccessResponse(T data, string message = "İşlem başarılı")
			=> new ServiceResponse<T>
			{
				Success = true,
				Data = data,
				Message = message
			};

		/// <summary>
		/// Liste için başarılı response
		/// </summary>
		public static ServiceResponse<T> SuccessResponse(IEnumerable<T> dataList, string message = "İşlem başarılı")
			=> new ServiceResponse<T>
			{
				Success = true,
				DataList = dataList?.ToList() ?? new List<T>(),
				Message = message
			};

		/// <summary>
		/// JWT token içeren başarılı response
		/// </summary>
		public static ServiceResponse<T> TokenResponse(T data, string jwt, string refresh, string message = "Token üretildi")
			=> new ServiceResponse<T>
			{
				Success = true,
				Data = data,
				JwtToken = jwt,
				RefreshToken = refresh,
				Message = message
			};

		/// <summary>
		/// Başarısız response (tek hata)
		/// </summary>
		public static ServiceResponse<T> FailureResponse(string error, string message = "İşlem başarısız")
			=> new ServiceResponse<T>
			{
				Success = false,
				Errors = new List<string> { error },
				Message = message
			};

		/// <summary>
		/// Başarısız response (çoklu hata)
		/// </summary>
		public static ServiceResponse<T> FailureResponse(IEnumerable<string> errors, string message = "İşlem başarısız")
			=> new ServiceResponse<T>
			{
				Success = false,
				Errors = errors?.ToList() ?? new List<string>(),
				Message = message
			};

		#endregion

		#region Fluent Helpers

		public ServiceResponse<T> WithMeta(string key, object value)
		{
			Meta[key] = value;
			return this;
		}

		public ServiceResponse<T> WithMessage(string message)
		{
			Message = message;
			return this;
		}

		public ServiceResponse<T> WithErrors(params string[] errors)
		{
			Errors.AddRange(errors);
			return this;
		}

		#endregion
	}
}