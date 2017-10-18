﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorService.Models
{
    public class ErrorDto
    {
        #region Properties
        public string ErrorCode { get; private set; }

        public int ErrorStatus { get; private set; }

        public string ErrorMessage { get; private set; }

        public string FormattedLog { get; private set; }
        #endregion

        #region .Ctor
        public ErrorDto(string code, int status, string message)
        {
            this.ErrorCode = code;
            this.ErrorStatus = status;
            this.ErrorMessage = message;
        }
        #endregion

        #region Methods
        private void CreateFoormatedLog()
        {
            FormattedLog = "Create complicated Log";
        }
        #endregion
    }
}