using System;

namespace SharpVectors.Dom.Svg
{
	/// <summary>
	/// The SvgPathSeg interface is a base interface that corresponds to a single command within a path data specification. 
	/// </summary>
	/// <developer>niklas@protocol7.com</developer>
	/// <completed>100</completed>
	public interface ISvgPathSeg
	{
		SvgPathSegType PathSegType{get;}
		string PathSegTypeAsLetter{get;}
	}
}