using Domain.Entities;
using Infra.Repositories;
using System;
using System.Collections.Generic;


/*
 *  Questão 1
 *  Faça um programa que liste na console todos os pedidos de venda (SalesOrder) de todos os usuários (User). 
 * 
 * Output esperado
 * User 1
 * -- SalesOrderNumber, TotalValue, ItensCount
 * -- SalesOrderNumber, TotalValue, ItensCount
 * -- SalesOrderNumber, TotalValue, ItensCount
 * User 2
 * -- SalesOrderNumber, TotalValue, ItensCount
 * User N
 * -- SalesOrderNumber, TotalValue, ItensCount
 * -- SalesOrderNumber, TotalValue, ItensCount
 * 
 * Onde "User N" pode ser substituído pelo campo Name da tabela User e SalesOrderNumber, TotalValue, ItensCount os campos da tabela SalesOrder.
 *
 */
namespace Questao1
{

    class Program
    {

        static void Main(string[] args)
        {


            SalesOrderRepository salesOrderRepository = new SalesOrderRepository();
            IEnumerable<SalesOrder> salesOrders = salesOrderRepository.GetAllWithUser();


            Console.WriteLine("Questão 1 - Listagem de pedidos de vendas de todos os usuários: ");
            Console.WriteLine();

            foreach (var sales in salesOrders)
            {
                Console.WriteLine($"{sales.User.Name} {sales.Title}");
                Console.WriteLine($"SalesOrderNumber: {sales.Id}, Description: {sales.Description}, Value: {sales.Value}");
                Console.WriteLine();
            }

            Console.ReadKey();


        }
    }
}
