// ***********************************************************************
// Assembly         : ACBr.Net.NFSe
// Author           : RFTD
// Created          : 06-19-2016
//
// Last Modified By : RFTD
// Last Modified On : 06-28-2016
// ***********************************************************************
// <copyright file="MunicipioNFSe.cs" company="ACBr.Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2016 Grupo ACBr.Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;

namespace ACBr.Net.NFSe.Providers
{
	[Serializable]
	public class MunicipioNFSe
	{
		#region Constructors

		public MunicipioNFSe()
		{
			UrlHomologacao = new Dictionary<TipoUrl, string>(9);
			UrlProducao = new Dictionary<TipoUrl, string>(9);

			UrlProducao[TipoUrl.Enviar] = string.Empty;
			UrlProducao[TipoUrl.EnviarSincrono] = string.Empty;
			UrlProducao[TipoUrl.CancelaNFSe] = string.Empty;
			UrlProducao[TipoUrl.ConsultaNFSe] = string.Empty;
			UrlProducao[TipoUrl.ConsultaNFSeRps] = string.Empty;
			UrlProducao[TipoUrl.ConsultarLoteRps] = string.Empty;
			UrlProducao[TipoUrl.ConsultarSituacao] = string.Empty;
			UrlProducao[TipoUrl.ConsultarSequencialRps] = string.Empty;
			UrlProducao[TipoUrl.SubstituirNFSe] = string.Empty;

			UrlHomologacao[TipoUrl.Enviar] = string.Empty;
			UrlHomologacao[TipoUrl.EnviarSincrono] = string.Empty;
			UrlHomologacao[TipoUrl.CancelaNFSe] = string.Empty;
			UrlHomologacao[TipoUrl.ConsultaNFSe] = string.Empty;
			UrlHomologacao[TipoUrl.ConsultaNFSeRps] = string.Empty;
			UrlHomologacao[TipoUrl.ConsultarLoteRps] = string.Empty;
			UrlHomologacao[TipoUrl.ConsultarSituacao] = string.Empty;
			UrlHomologacao[TipoUrl.ConsultarSequencialRps] = string.Empty;
			UrlHomologacao[TipoUrl.SubstituirNFSe] = string.Empty;
		}

		#endregion Constructors

		#region Propriedades

		public int Codigo { get; set; }

		public int CodigoSiafi { get; set; }

		public string Nome { get; set; }

		public string UF { get; set; }

		public string Provedor { get; set; }

		public int TamanhoIM { get; set; }

		public Dictionary<TipoUrl, string> UrlHomologacao { get; }

		public Dictionary<TipoUrl, string> UrlProducao { get; }

		#endregion Propriedades
	}
}