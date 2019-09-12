

--查消费金额
select 
 convert(varchar(7),exp_date,111) as 月份,
count(exp_item) as 消费计数,sum(exp_price*exp_count) as 花费金额
from
tbl_expend 
where 
 convert(varchar(7),exp_date,111) between  '2019/09' and '2019/09'
 and exp_valid = 1 and exp_public =1
 group by convert(varchar(7),exp_date,111)

 --查收款数及金额
 select 
	distinct inc_source,convert(varchar(7),inc_date,111) as 月份,count(inc_amount) as 收款次数,sum(inc_amount) as 收款金额
 from tbl_income 
 where 
 convert(varchar(7),inc_date,111) between  '2019/09' and '2019/09' 
 and inc_valid = 1 and inc_public = 1
 group by convert(varchar(7),inc_date,111) ,inc_source


 --查分类
select 
distinct exp_type as 物品类型 ,count (exp_type) as 次数,sum(exp_price*exp_count) as 金额
from
tbl_expend 
 where 
 convert(varchar(7),exp_date,111) between  '2019/09' and '2019/09'
 and exp_valid = 1 and exp_public =1
 group by exp_type

 union all
 select '合计'as 物品类型, 1 as 次数,sum(exp_price*exp_count) as 金额
 from
tbl_expend 
 where 
 convert(varchar(7),exp_date,111) between  '2019/09' and '2019/09'
 and exp_valid = 1 and exp_public =1


alter table tbl_income add inc_method varchar(50) not null default ''

--alter table tbl_income drop column inc_method
--删除列
