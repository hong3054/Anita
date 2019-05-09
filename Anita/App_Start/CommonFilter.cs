using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Anita.App_Start
{
    public class CommonFilter
    {
    }

    /// <summary>
    /// 统一异常处理
    /// </summary>
    public class ExceptionHandle : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            context.ExceptionHandled = true;
            ContentResult result = new ContentResult();
            HttpRequestBase request = context.HttpContext.Request;
            if (request.IsAjaxRequest())
            {
                result.Content = "{\"code\":0,\"message\":\"抱歉，处理您的请求时遇到错误！\"}";
            }
            else {
                result.Content = "抱歉，处理您的请求时遇到错误！";
            }
            context.Result = result;
        }
    }
}