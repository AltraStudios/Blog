<?php
public function Get($id)
{
    $post = Post::find($id);

    $nextPost = Post::where([['id','>',$post->id]->orderBy('id', 'asc')->take(1)->first();

    $prevPost = Post::where([['id','<',$post->id]->orderBy('id', 'desc')->take(1)->first();

    $data = [
        'post'      =>  $post,
        'nextPost'  =>  $nextPost,
        'prevPost'  =>  $prevPost
    ];

    return view('Posts.index')->with('model',$data);

}
