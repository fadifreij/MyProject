// Seeding  eCommerce application 

using System.Text.Json;
using System;
using ECommerce.Seeding.Models;
using Microsoft.EntityFrameworkCore;
using ECommerce.Domain.Entities;
using E_Commerce.Domain.Entities;
using ECommerce.Seeding;
using ECommerce.Seeding.Data;
using ECommerce.Seeding.Services;

Console.WriteLine("Inserting data to Ecommerce database ....");


DataInserter dataInserter = new();
//////////////////////
// Categories Table //
//////////////////////
dataInserter.Insert(CategoryData.categories, "categories");

///////////////////////
// Departments Table //
///////////////////////
dataInserter.Insert(DepartmentData.departments, "departments");

///////////////////////
// Products Table    //
///////////////////////
dataInserter.Insert(ProductData.products, "products");


////////////////////////////////////////////////////////////////////
// ProcutImages Table ////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////
dataInserter.InsertProductImages();

///////////////////////
// Sections Table    //
///////////////////////
dataInserter.Insert(SectionData.sections, "sections");






