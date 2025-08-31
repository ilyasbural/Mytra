namespace Mytra.Common
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
		public List<string> Errors { get; set; } = new List<string>();

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
		public Dictionary<string, object> Meta { get; set; } = new Dictionary<string, object>();

		/// <summary>
		/// Başarılı response oluşturmak için helper
		/// </summary>
		public static ServiceResponse<T> SuccessResponse(T data, string message = "İşlem başarılı")
		{
			return new ServiceResponse<T>
			{
				Success = true,
				Data = data,
				Message = message
			};
		}

		/// <summary>
		/// Liste response oluşturmak için helper
		/// </summary>
		public static ServiceResponse<T> SuccessResponse(List<T> dataList, string message = "İşlem başarılı")
		{
			return new ServiceResponse<T>
			{
				Success = true,
				DataList = dataList,
				Message = message
			};
		}

		/// <summary>
		/// Hatalı response oluşturmak için helper
		/// </summary>
		public static ServiceResponse<T> FailureResponse(List<string> errors, string message = "İşlem başarısız")
		{
			return new ServiceResponse<T>
			{
				Success = false,
				Errors = errors,
				Message = message
			};
		}

		public static ServiceResponse<T> FailureResponse(string error, string message = "İşlem başarısız")
		{
			return new ServiceResponse<T>
			{
				Success = false,
				Errors = new List<string> { error },
				Message = message
			};
		}
	}
}