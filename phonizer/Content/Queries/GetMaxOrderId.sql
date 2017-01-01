select
	max(ID)	as Id
	from wp_posts
	where post_type = 'shop_order';