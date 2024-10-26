import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LanguageMenuHeaderComponent } from './language-menu-header.component';

describe('LanguageMenuHeaderComponent', () => {
  let component: LanguageMenuHeaderComponent;
  let fixture: ComponentFixture<LanguageMenuHeaderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [LanguageMenuHeaderComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LanguageMenuHeaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
