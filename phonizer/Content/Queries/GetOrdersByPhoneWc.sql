select
	max(pmo.meta_id)															as Id,
	max(p.post_date)															as 'Date',
	max(case when pmo.meta_key = '_billing_first_name' then pmo.meta_value end)	as 'Name',
	max(case when pmo.meta_key = '_billing_phone' then pmo.meta_value end)		as Phone,
	max(case when pmo.meta_key = '_billing_address_1' then pmo.meta_value end)	as Street,
	max(case when pmo.meta_key = '_billing_address_2' then pmo.meta_value end)	as HouseNumber,
	(select
		group_concat(order_item_name separator ' | ' )
        from wp_woocommerce_order_items
        where order_id = pmo.post_id
	)																			as OrderItems,
	max(case when pmo.meta_key = '_order_total' then pmo.meta_value end)		as OrderSum,
	max(case when pmo.meta_key = '_payment_method' then pmo.meta_value end) 		as PaymentMethod
	from wp_postmeta as pmi
		inner join wp_postmeta as pmo on
			pmi.post_id = pmo.post_id
		inner join wp_posts as p on
			p.ID = pmo.post_id
	where pmi.meta_value like concat("%", @phonePattern, "%")
    group by pmi.post_id;