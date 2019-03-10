<?php
public function GetByUrl($url)
{
return DB::select('select p1.*,p3.title as prevTitle, p3.url as prevUrl, p2.title as nextTitle, p2.url as nextUrl from posts as p1
        left join posts as p2 on p2.id > p1.id
        left join posts as p3 on p3.id < p1.id
        where p1.id = :id 
        order by p3.id desc
        limit 1
        ',[ 'id'  => $id]);
}
