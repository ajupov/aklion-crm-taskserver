select
	ID	as Id
	from wp_posts
	where post_type = 'shop_order'
		and ID > @id
	limit 1;