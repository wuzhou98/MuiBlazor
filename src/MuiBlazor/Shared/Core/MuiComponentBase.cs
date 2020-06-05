using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace MuiBlazor {
	public class MuiComponentBase : ComponentBase {
		protected virtual string CssClass {
			get {
				return "";
			}
		}

		[Parameter]
		public virtual string Style {get;set;}


	}
}
