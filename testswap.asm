_Znam@plt:
 jmpq *0x200b12(%rip) # 601018 <_Znam@GLIBCXX_3.4>
 pushq $0x0
 jmpq 4004f0 <.plt>
_ZNSt8ios_base4InitC1Ev@plt:
 jmpq *0x200b02(%rip) # 601028 <_ZNSt8ios_base4InitC1Ev@GLIBCXX_3.4>
 pushq $0x2
 jmpq 4004f0 <.plt>
_ZNSt8ios_base4InitD1Ev@plt:
 jmpq *0x200afa(%rip) # 601030 <_ZNSt8ios_base4InitD1Ev@GLIBCXX_3.4>
 pushq $0x3
 jmpq 4004f0 <.plt>
_GLOBAL__sub_I_example.cpp:
 push %rbp
 mov %rsp,%rbp
 callq 400540 <__cxx_global_var_init>
 pop %rbp
 retq 
 nopl 0x0(%rax,%rax,1)
_dl_relocate_static_pie:
 repz retq 
 nopw %cs:0x0(%rax,%rax,1)
 nopl 0x0(%rax)
main:
 push %rbp
 mov %rsp,%rbp
 sub $0x10,%rsp
 mov $0x10,%eax
 mov %eax,%edi
 callq 400500 <_Znam@plt>
 mov $0x18,%ecx
 mov %ecx,%edi
 mov %rax,-0x8(%rbp)
 callq 400500 <_Znam@plt>
 mov -0x8(%rbp),%rdi
 mov %rax,(%rdi)
 mov -0x8(%rbp),%rax
 mov 0x18(%rax),%rax
 mov -0x8(%rbp),%rdi
 mov %rax,0x8(%rdi)
 mov -0x8(%rbp),%rdi
 mov -0x8(%rbp),%rax
 add $0x8,%rax
 mov %rax,%rsi
 callq 4006f0 <_ZSt4swapIPiENSt9enable_ifIXsr6__and_ISt6__not_ISt15__is_tuple_likeIT_EESt21is_move_constructibleIS4_ESt18is_move_assignableIS4_EEE5valueEvE4typeERS4_SD_>
 xor %eax,%eax
 add $0x10,%rsp
 pop %rbp
 retq 
 nopw 0x0(%rax,%rax,1)
_ZSt4swapIPiENSt9enable_ifIXsr6__and_ISt6__not_ISt15__is_tuple_likeIT_EESt21is_move_constructibleIS4_ESt18is_move_assignableIS4_EEE5valueEvE4typeERS4_SD_:
 push %rbp
 mov %rsp,%rbp
 sub $0x20,%rsp
 mov %rdi,-0x8(%rbp)
 mov %rsi,-0x10(%rbp)
 mov -0x8(%rbp),%rdi
 callq 400740 <_ZSt4moveIRPiEONSt16remove_referenceIT_E4typeEOS3_>
 mov (%rax),%rax
 mov %rax,-0x18(%rbp)
 mov -0x10(%rbp),%rdi
 callq 400740 <_ZSt4moveIRPiEONSt16remove_referenceIT_E4typeEOS3_>
 mov (%rax),%rax
 mov -0x8(%rbp),%rsi
 mov %rax,(%rsi)
 lea -0x18(%rbp),%rdi
 callq 400740 <_ZSt4moveIRPiEONSt16remove_referenceIT_E4typeEOS3_>
 mov (%rax),%rax
 mov -0x10(%rbp),%rsi
 mov %rax,(%rsi)
 add $0x20,%rsp
 pop %rbp
 retq 
 nopl 0x0(%rax)
_ZSt4moveIRPiEONSt16remove_referenceIT_E4typeEOS3_:
 push %rbp
 mov %rsp,%rbp
 mov %rdi,-0x8(%rbp)
 mov -0x8(%rbp),%rax
 pop %rbp
 retq 
 xchg %ax,%ax
