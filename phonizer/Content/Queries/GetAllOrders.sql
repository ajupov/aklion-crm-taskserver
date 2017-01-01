select
	max(pm.meta_id)																	as Id,
	max(p.post_date)																	as 'Date',
	max(case when pm.meta_key = '_billing_first_name' then pm.meta_value end)			as 'Name',
	coalesce(max(case when pm.meta_key = '_billing_email' then pm.meta_value end), '')	as Email,
	max(case when pm.meta_key = '_billing_phone' then pm.meta_value end)				as Phone,
	max(case when pm.meta_key = '_billing_address_1' then pm.meta_value end) 			as Street,
	max(case when pm.meta_key = '_billing_address_2' then pm.meta_value end) 			as HouseNumber,
	(select
		group_concat(order_item_name separator ' | ' )
        from wp_woocommerce_order_items
        where order_id = post_id
	)																					as OrderItems,
	max(case when pm.meta_key = '_order_total' then pm.meta_value end) 					as OrderSum,
	max(case when pm.meta_key = '_payment_method' then pm.meta_value end) 				as PaymentMethod
	from wp_postmeta as pm
		inner join wp_posts as p on
			p.ID = pm.post_id
	group by pm.post_id
		having max(case when pm.meta_key = '_billing_first_name' then pm.meta_value end) is not null
			and max(p.post_date) between @startDate and @endDate;