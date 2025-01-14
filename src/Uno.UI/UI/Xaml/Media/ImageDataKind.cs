﻿namespace Uno.UI.Xaml.Media;

internal enum ImageDataKind
{
	/// <summary>
	/// The source is empty and the target visual element should be cleared
	/// </summary>
	Empty,

	/// <summary>
	/// An Url (usually http: or https:)
	/// </summary>
	Url,

	/// <summary>
	/// A data: data payload encoded in the url itself.  Usually using base64.
	/// https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/Data_URIs
	/// </summary>
	DataUri,

	/// <summary>
	/// A byte array.
	/// </summary>
	ByteArray,

	/// <summary>
	/// A native image.
	/// </summary>
	NativeImage,

	/// <summary>
	/// Skia composition surface.
	/// </summary>
	CompositionSurface,

	/// <summary>
	/// The image failed to load (cf. The Error property)
	/// </summary>
	Error = 256
}
