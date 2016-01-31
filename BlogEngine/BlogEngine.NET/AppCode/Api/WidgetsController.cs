﻿using BlogEngine.Core.Data.Contracts;
using BlogEngine.Core.Data.Models;
using BlogEngine.Core.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

public class WidgetsController : ApiController
{
    readonly IWidgetsRepository repository;

    public WidgetsController(IWidgetsRepository repository)
    {
        this.repository = repository;
    }

    public WidgetsVM Get()
    {
        return new WidgetsVM();
    }

}