namespace Mytra.Utilize
{
	/// <summary>
	/// Service Layer içinde kullanılan ortak dönüş tipi.
	/// Hem CRUD hem de Business metotları için standart yapı sağlar.
	/// </summary>
	public class DataService<T>
	{
		/// <summary>
		/// İşlem başarılı mı? (true/false)
		/// </summary>
		public bool Success { get; set; }

		/// <summary>
		/// Açıklama veya kullanıcıya dönecek mesaj
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
		/// Ek bilgiler (opsiyonel metadata)
		/// </summary>
		public Dictionary<string, object> Meta { get; set; } = new Dictionary<string, object>();

		#region Helper Methods

		/// <summary>
		/// Başarılı tekil sonuç response
		/// </summary>
		public static DataService<T> SuccessResult(T data, string message = "İşlem başarılı")
		{
			return new DataService<T>
			{
				Success = true,
				Data = data,
				Message = message
			};
		}

		/// <summary>
		/// Başarılı liste response
		/// </summary>
		public static DataService<T> SuccessResult(List<T> dataList, string message = "İşlem başarılı")
		{
			return new DataService<T>
			{
				Success = true,
				DataList = dataList,
				Message = message
			};
		}

		/// <summary>
		/// Hatalı response (birden fazla hata)
		/// </summary>
		public static DataService<T> FailureResult(List<string> errors, string message = "İşlem başarısız")
		{
			return new DataService<T>
			{
				Success = false,
				Errors = errors,
				Message = message
			};
		}

		/// <summary>
		/// Hatalı response (tek hata)
		/// </summary>
		public static DataService<T> FailureResult(string error, string message = "İşlem başarısız")
		{
			return new DataService<T>
			{
				Success = false,
				Errors = new List<string> { error },
				Message = message
			};
		}

		#endregion
	}
}